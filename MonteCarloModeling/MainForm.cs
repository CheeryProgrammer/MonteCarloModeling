using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloModeling
{
	public partial class MainForm : Form
	{
		private Model _model;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_model = new Model();
		}

		private void btnRunModeling_Click(object sender, EventArgs e)
		{
			InitializeModel();

			var count = Convert.ToInt32(nudCount.Value);
			_model.Run(count);
			lblMonteCarloResult.Text = string.Format("{0:F} %", _model.DestroyChance);
		}

		private void InitializeModel()
		{
			var masterAccuracy = Convert.ToDouble(nudMasterAccuracy.Value);
			var master = new MasterDestroyer(masterAccuracy);

			var slaveAccuracy = Convert.ToDouble(nudSlaveAccuracy.Value);
			var slaves = new []{new SlaveDestroyer(slaveAccuracy),
				new SlaveDestroyer(slaveAccuracy) };

			var defenseAccuracy = Convert.ToDouble(nudDefenseAccuracy.Value);
			var defense = new Defense(defenseAccuracy);

			var accuracy11 = Convert.ToDouble(nud11Accuracy.Value);
			var accuracyAll = Convert.ToDouble(nudAllAccuracy.Value);

			_model.Initialize(master,slaves,defense,
				accuracyAll, accuracy11);
		}

		private void btnRunAnalytic_Click(object sender, EventArgs e)
		{
			CalculateAnalytically();
		}

		private void CalculateAnalytically()
		{
			var P_1_0 = Convert.ToDouble(nudMasterAccuracy.Value) / 100.0;
			var P_0_1 = Convert.ToDouble(nudSlaveAccuracy.Value) / 100.0;
			var p_def = Convert.ToDouble(nudDefenseAccuracy.Value) / 100.0;
			var P_1_1 = Convert.ToDouble(nud11Accuracy.Value) / 100.0;
			var P_1_2 = Convert.ToDouble(nudAllAccuracy.Value) / 100.0;

			var p = (1.0 - p_def) * ((1.0 - p_def) * ((1.0 - p_def) * P_1_2 + 2.0 * p_def * P_1_1) + p_def * p_def * P_1_0 + p_def * P_0_1 * (2.0 - P_0_1 * (1.0 - p_def)));
			// (1-p)∙((1-p)∙((1-p)∙P_1,2+2∙p∙P_1,1 )+p^2∙P_1,0+p∙P_0,1∙(2-P_0,1∙(1-p)))
			lblAnalyticResult.Text = string.Format("{0:F} %", p * 100.0);
		}
	}
}

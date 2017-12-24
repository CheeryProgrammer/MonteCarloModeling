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
		private static int N;
		private static int _counter;
		private Model _model;
		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			_model = new Model();
			bWorker.DoWork += BWorker_DoWork;
			bWorker.RunWorkerCompleted += BWorker_RunWorkerCompleted;
			bWorker.ProgressChanged += BWorker_ProgressChanged;
		}

		private void BWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			var pc = e.ProgressPercentage;
			pbProgress.Value = pc;
			lblPercentage.Text = string.Format("{0} %", pc);
			lblMonteCarloResult.Text = string.Format("{0:F} %", N == 0 ? 0 : 100.0 * _counter / N);
		}

		private void BWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			lblMonteCarloResult.Text = string.Format("{0:F} %", N == 0 ? 0 : 100.0 * _counter / N);
			btnRunModeling.Enabled = true;
		}

		private void btnRunModeling_Click(object sender, EventArgs e)
		{
			InitializeModel();
			bWorker.RunWorkerAsync();
			btnRunModeling.Enabled = false;
		}

		private void BWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			RunModeling();
		}

		private void RunModeling()
		{
			N = Convert.ToInt32(nudCount.Value);

			if (N < 0)
				return;

			_counter = 0;

			var step = N / 100;

			for (int i = 0; i < N; i++)
			{
				if (_model.Run())
					_counter++;

				if (i % step == 0)
					bWorker.ReportProgress((int)(100 * ((double)i / N)));
			}
			bWorker.ReportProgress(100);
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

		private void btnRandomizeCondition_Click(object sender, EventArgs e)
		{
			// Set random initial condition
			nudMasterAccuracy.Value = (decimal)Model.GetRandom();
			nudSlaveAccuracy.Value = (decimal)Model.GetRandom();
			nudDefenseAccuracy.Value = (decimal)Model.GetRandom();
			nud11Accuracy.Value = (decimal)Model.GetRandom();
			nudAllAccuracy.Value = (decimal)Model.GetRandom();
		}
	}
}

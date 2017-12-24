namespace MonteCarloModeling
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblDef = new System.Windows.Forms.Label();
			this.nudDefenseAccuracy = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.nudAllAccuracy = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.nud11Accuracy = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.nudSlaveAccuracy = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.nudMasterAccuracy = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblCount = new System.Windows.Forms.Label();
			this.nudCount = new System.Windows.Forms.NumericUpDown();
			this.btnRunModeling = new System.Windows.Forms.Button();
			this.btnRunAnalytic = new System.Windows.Forms.Button();
			this.lblExeAnalytic = new System.Windows.Forms.Label();
			this.gbResults = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.lblMonteCarloResult = new System.Windows.Forms.Label();
			this.lblAnalyticResult = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDefenseAccuracy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAllAccuracy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud11Accuracy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSlaveAccuracy)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMasterAccuracy)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
			this.gbResults.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.nudMasterAccuracy);
			this.groupBox1.Controls.Add(this.nudSlaveAccuracy);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.nud11Accuracy);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.nudAllAccuracy);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.nudDefenseAccuracy);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.lblDef);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox1.Location = new System.Drawing.Point(13, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 169);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Initial conditions";
			// 
			// lblDef
			// 
			this.lblDef.AutoSize = true;
			this.lblDef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDef.Location = new System.Drawing.Point(7, 29);
			this.lblDef.Name = "lblDef";
			this.lblDef.Size = new System.Drawing.Size(124, 13);
			this.lblDef.TabIndex = 0;
			this.lblDef.Text = "Defence accuracy (p), %";
			// 
			// nudDefenseAccuracy
			// 
			this.nudDefenseAccuracy.DecimalPlaces = 1;
			this.nudDefenseAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudDefenseAccuracy.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			this.nudDefenseAccuracy.Location = new System.Drawing.Point(265, 27);
			this.nudDefenseAccuracy.Name = "nudDefenseAccuracy";
			this.nudDefenseAccuracy.Size = new System.Drawing.Size(93, 20);
			this.nudDefenseAccuracy.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(7, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "All accuracy (P1,2), %";
			// 
			// nudAllAccuracy
			// 
			this.nudAllAccuracy.DecimalPlaces = 1;
			this.nudAllAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudAllAccuracy.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			this.nudAllAccuracy.Location = new System.Drawing.Point(265, 53);
			this.nudAllAccuracy.Name = "nudAllAccuracy";
			this.nudAllAccuracy.Size = new System.Drawing.Size(93, 20);
			this.nudAllAccuracy.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(7, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(180, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Master and slave accuracy (P1,1), %";
			// 
			// nud11Accuracy
			// 
			this.nud11Accuracy.DecimalPlaces = 1;
			this.nud11Accuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nud11Accuracy.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			this.nud11Accuracy.Location = new System.Drawing.Point(265, 79);
			this.nud11Accuracy.Name = "nud11Accuracy";
			this.nud11Accuracy.Size = new System.Drawing.Size(93, 20);
			this.nud11Accuracy.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(7, 133);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(126, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Slave accuracy (P0,1), %";
			// 
			// nudSlaveAccuracy
			// 
			this.nudSlaveAccuracy.DecimalPlaces = 1;
			this.nudSlaveAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudSlaveAccuracy.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			this.nudSlaveAccuracy.Location = new System.Drawing.Point(265, 131);
			this.nudSlaveAccuracy.Name = "nudSlaveAccuracy";
			this.nudSlaveAccuracy.Size = new System.Drawing.Size(93, 20);
			this.nudSlaveAccuracy.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(7, 107);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(131, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Master accuracy (P1,0), %";
			// 
			// nudMasterAccuracy
			// 
			this.nudMasterAccuracy.DecimalPlaces = 1;
			this.nudMasterAccuracy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudMasterAccuracy.Increment = new decimal(new int[] {
            2,
            0,
            0,
            65536});
			this.nudMasterAccuracy.Location = new System.Drawing.Point(265, 105);
			this.nudMasterAccuracy.Name = "nudMasterAccuracy";
			this.nudMasterAccuracy.Size = new System.Drawing.Size(93, 20);
			this.nudMasterAccuracy.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnRunModeling);
			this.groupBox2.Controls.Add(this.lblCount);
			this.groupBox2.Controls.Add(this.nudCount);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox2.Location = new System.Drawing.Point(13, 189);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(197, 87);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Monte Carlo modeling";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnRunAnalytic);
			this.groupBox3.Controls.Add(this.lblExeAnalytic);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.groupBox3.Location = new System.Drawing.Point(216, 189);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(161, 87);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Analytic calculation";
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblCount.Location = new System.Drawing.Point(7, 31);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(89, 13);
			this.lblCount.TabIndex = 0;
			this.lblCount.Text = "Experiment count";
			// 
			// nudCount
			// 
			this.nudCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nudCount.Location = new System.Drawing.Point(98, 29);
			this.nudCount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.nudCount.Name = "nudCount";
			this.nudCount.Size = new System.Drawing.Size(93, 20);
			this.nudCount.TabIndex = 1;
			// 
			// btnRunModeling
			// 
			this.btnRunModeling.Location = new System.Drawing.Point(98, 56);
			this.btnRunModeling.Name = "btnRunModeling";
			this.btnRunModeling.Size = new System.Drawing.Size(93, 23);
			this.btnRunModeling.TabIndex = 2;
			this.btnRunModeling.Text = "Run";
			this.btnRunModeling.UseVisualStyleBackColor = true;
			this.btnRunModeling.Click += new System.EventHandler(this.btnRunModeling_Click);
			// 
			// btnRunAnalytic
			// 
			this.btnRunAnalytic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRunAnalytic.Location = new System.Drawing.Point(62, 56);
			this.btnRunAnalytic.Name = "btnRunAnalytic";
			this.btnRunAnalytic.Size = new System.Drawing.Size(93, 23);
			this.btnRunAnalytic.TabIndex = 2;
			this.btnRunAnalytic.Text = "Run";
			this.btnRunAnalytic.UseVisualStyleBackColor = true;
			this.btnRunAnalytic.Click += new System.EventHandler(this.btnRunAnalytic_Click);
			// 
			// lblExeAnalytic
			// 
			this.lblExeAnalytic.AutoSize = true;
			this.lblExeAnalytic.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.lblExeAnalytic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblExeAnalytic.Location = new System.Drawing.Point(6, 31);
			this.lblExeAnalytic.Name = "lblExeAnalytic";
			this.lblExeAnalytic.Size = new System.Drawing.Size(139, 13);
			this.lblExeAnalytic.TabIndex = 0;
			this.lblExeAnalytic.Text = "Execute analytic calculation";
			// 
			// gbResults
			// 
			this.gbResults.Controls.Add(this.tableLayoutPanel1);
			this.gbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbResults.Location = new System.Drawing.Point(13, 283);
			this.gbResults.Name = "gbResults";
			this.gbResults.Size = new System.Drawing.Size(364, 106);
			this.gbResults.TabIndex = 2;
			this.gbResults.TabStop = false;
			this.gbResults.Text = "Results";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.lblAnalyticResult, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblMonteCarloResult, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.28736F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.71265F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 87);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Silver;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(173, 21);
			this.label5.TabIndex = 0;
			this.label5.Text = "Monte Carlo method";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Silver;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(182, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 21);
			this.label6.TabIndex = 1;
			this.label6.Text = "Analytic method";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblMonteCarloResult
			// 
			this.lblMonteCarloResult.BackColor = System.Drawing.Color.Black;
			this.lblMonteCarloResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMonteCarloResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMonteCarloResult.ForeColor = System.Drawing.Color.Green;
			this.lblMonteCarloResult.Location = new System.Drawing.Point(3, 21);
			this.lblMonteCarloResult.Name = "lblMonteCarloResult";
			this.lblMonteCarloResult.Size = new System.Drawing.Size(173, 66);
			this.lblMonteCarloResult.TabIndex = 2;
			this.lblMonteCarloResult.Text = "N/A";
			this.lblMonteCarloResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblAnalyticResult
			// 
			this.lblAnalyticResult.BackColor = System.Drawing.Color.Black;
			this.lblAnalyticResult.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblAnalyticResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAnalyticResult.ForeColor = System.Drawing.Color.OrangeRed;
			this.lblAnalyticResult.Location = new System.Drawing.Point(182, 21);
			this.lblAnalyticResult.Name = "lblAnalyticResult";
			this.lblAnalyticResult.Size = new System.Drawing.Size(173, 66);
			this.lblAnalyticResult.TabIndex = 3;
			this.lblAnalyticResult.Text = "N/A";
			this.lblAnalyticResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 401);
			this.Controls.Add(this.gbResults);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(405, 440);
			this.MinimumSize = new System.Drawing.Size(405, 440);
			this.Name = "MainForm";
			this.Text = "Monte Carlo modeling";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDefenseAccuracy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudAllAccuracy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud11Accuracy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudSlaveAccuracy)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMasterAccuracy)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
			this.gbResults.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblDef;
		private System.Windows.Forms.NumericUpDown nudMasterAccuracy;
		private System.Windows.Forms.NumericUpDown nudSlaveAccuracy;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown nud11Accuracy;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown nudAllAccuracy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nudDefenseAccuracy;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnRunModeling;
		private System.Windows.Forms.Label lblCount;
		private System.Windows.Forms.NumericUpDown nudCount;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button btnRunAnalytic;
		private System.Windows.Forms.Label lblExeAnalytic;
		private System.Windows.Forms.GroupBox gbResults;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lblAnalyticResult;
		private System.Windows.Forms.Label lblMonteCarloResult;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
	}
}


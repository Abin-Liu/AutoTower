namespace AutoTower
{
	partial class FormMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.chkAlert = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cmbSlot = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbDifficulty = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// chkAlert
			// 
			this.chkAlert.AutoSize = true;
			this.chkAlert.Location = new System.Drawing.Point(20, 64);
			this.chkAlert.Name = "chkAlert";
			this.chkAlert.Size = new System.Drawing.Size(132, 16);
			this.chkAlert.TabIndex = 4;
			this.chkAlert.Text = "战斗胜利后响铃提醒";
			this.chkAlert.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cmbSlot);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmbDifficulty);
			this.groupBox1.Controls.Add(this.chkAlert);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(408, 95);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "仅适用网易MuMu模拟器1600*900分辨率";
			// 
			// cmbSlot
			// 
			this.cmbSlot.FormattingEnabled = true;
			this.cmbSlot.Items.AddRange(new object[] {
            "左",
            "中",
            "右"});
			this.cmbSlot.Location = new System.Drawing.Point(65, 28);
			this.cmbSlot.Name = "cmbSlot";
			this.cmbSlot.Size = new System.Drawing.Size(121, 20);
			this.cmbSlot.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(18, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "关卡：";
			// 
			// cmbDifficulty
			// 
			this.cmbDifficulty.FormattingEnabled = true;
			this.cmbDifficulty.Items.AddRange(new object[] {
            "简单",
            "普通",
            "困难"});
			this.cmbDifficulty.Location = new System.Drawing.Point(261, 28);
			this.cmbDifficulty.Name = "cmbDifficulty";
			this.cmbDifficulty.Size = new System.Drawing.Size(121, 20);
			this.cmbDifficulty.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(214, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 12);
			this.label1.TabIndex = 2;
			this.label1.Text = "难度：";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.label4.Location = new System.Drawing.Point(12, 122);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 13);
			this.label4.TabIndex = 1;
			this.label4.Text = "可按Pause键开始或停止";
			// 
			// btnStartStop
			// 
			this.btnStartStop.Location = new System.Drawing.Point(264, 117);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(75, 23);
			this.btnStartStop.TabIndex = 2;
			this.btnStartStop.Text = "▶ 开始";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(345, 117);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "退出";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(432, 151);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "英雄TD - 方尖塔助手";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox chkAlert;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbSlot;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbDifficulty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.Button btnExit;
	}
}


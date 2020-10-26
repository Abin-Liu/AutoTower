using System;
using System.Windows.Forms;
using Automation;

namespace AutoTower
{
	public partial class FormMain : AutomationForm
	{
		TowerThread m_thread = new TowerThread();

		public FormMain()
		{			
			InitializeComponent();
			SetThread(m_thread);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbSlot.SelectedIndex = 2;
			cmbDifficulty.SelectedIndex = 2;
		}		

		private void btnStartStop_Click(object sender, EventArgs e)
		{
			ToggleThread();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected override void OnThreadStart()
		{
			base.OnThreadStart();			
			m_thread.Slot = cmbSlot.SelectedIndex;
			m_thread.Difficulty = cmbDifficulty.SelectedIndex;
			m_thread.Alert = chkAlert.Checked;

			// 更新UI元素
			groupBox1.Enabled = false;
			btnStartStop.Text = "■ 停止";
		}

		protected override void OnThreadStop()
		{
			base.OnThreadStop();

			// 更新UI元素
			groupBox1.Enabled = true;
			btnStartStop.Text = "▶ 开始";
		}		
	}
}

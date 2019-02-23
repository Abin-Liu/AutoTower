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
			base.Form_OnLoad(sender, e);
			cmbSlot.SelectedIndex = 2;
			cmbDifficulty.SelectedIndex = 2;
		}

		private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			base.Form_OnClosing(sender, e);
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			base.Form_OnClosed(sender, e);
		}
		
		protected override void OnThreadStart()
		{
			base.OnThreadStart();
			groupBox1.Enabled = false;
			m_thread.Slot = cmbSlot.SelectedIndex + 1;
			m_thread.Difficulty = cmbDifficulty.SelectedIndex + 1;
		}

		protected override void OnThreadStop()
		{
			base.OnThreadStop();
			groupBox1.Enabled = true;			
		}
	}
}

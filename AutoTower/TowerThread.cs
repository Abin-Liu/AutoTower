using System;
using Automation;

namespace AutoTower
{
	class TowerThread : AutomationThread
	{		
		public int Difficulty { get; set; } = 2; // 0=简单, 1=普通, 2=困难
		public int Slot { get; set; } = 2; // 0=左, 1=中, 2=右	
		public bool Alert { get; set; } = false;

		public TowerThread()
		{
			TargetWndName = "守望英雄 - MuMu模拟器";
		}

		protected override bool PreStart()
		{
			if (!WaitForTowerUI(500))
			{
				LastError = "未处于方尖塔正确画面。";
				return false;
			}

			return true;
		}
		
		private bool WaitForTowerUI(int timeout)
		{
			return WaitForPixel(698, 854, 94, 57, 49, timeout);
		}

		protected override void OnStop()
		{
			base.OnStop();
			Alerting = false;
		}

		Random m_rand = new Random();

		protected override void ThreadProc()
		{
			while (true)
			{
				WaitForTowerUI(0); // 等待回到初始界面
				DelayBeforeAction();
				LeftClick(681 + 285 * Slot, 712); // 选择关卡：左/中/右

				// 检查是否需要花钻石重置挑战时间
				if (WaitForPixel(921, 608, 90, 132, 0, 1500))
				{
					DelayBeforeAction();
					LeftClick(921, 608); // 点击确定
					continue;
				}

				// 挑战流程
				WaitForPixel(920, 752, 255, 142, 121); // 等待难度选择界面
				DelayBeforeAction();
				LeftClick(904, 487 + 132 * Difficulty); // 选择难度：简单/普通/困难

				WaitForPixel(76, 736, 206, 115, 57); // 等待队伍选择界面
				DelayBeforeAction(m_rand.Next(2000, 6000)); // 随机等待2-6秒以防游戏断连
				LeftClick(1485, 832); // 点击战斗图标按钮

				WaitForPixel(1404, 855, 236, 226, 173); // 等待战斗界面
				DelayBeforeAction(m_rand.Next(1000, 3000)); // 随机等待1-3秒以防游戏断连
				LeftClick(1404, 855); // 点击立即结束按钮

				// 等待战斗失败界面
				if (WaitForPixel(964, 600, 90, 131, 184, 5000))
				{
					DelayBeforeAction();
					LeftClick(859, 803); // 点击返回按钮
				}
				// 检查是否胜利
				else if (WaitForPixel(466, 535, 173, 140, 99, 1000) && WaitForPixel(1104, 563, 165, 139, 98, 1000))
				{
					// 响铃提醒
					if (Alert)
					{
						Alerting = true;
					}

					// 已无继续操作的必要，等待用户终止线程
					while (true)
					{
						Sleep(1000);
					}					
				}				
			}
		}
	}
}

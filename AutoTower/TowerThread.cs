using System;
using Automation;

namespace AutoTower
{
	class TowerThread : AutomationThread
	{		
		public int Difficulty { get; set; } = 3; // 1=easy, 2=normal, 3=hard
		public int Slot { get; set; } = 3; // 1=left, 2=middle, 3=right	

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
				SelectSlot(); // 选择关卡：左/中/右

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
				SelectDifficulty(); // 选择难度：简单/普通/困难

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
					// 已无继续操作的必要，响铃直到用户终止线程
					Alerting = true;
					while (true)
					{
						Sleep(500);
					}					
				}				
			}
		}

		// 点击挑战按钮
		private void SelectSlot()
		{
			switch (Slot)
			{
				case 1:
					LeftClick(681, 712); // 左
					break;

				case 2:
					LeftClick(974, 712); // 中
					break;

				default:
					LeftClick(1251, 712); // 右
					break;
			}
		}

		// 点击相应的难度按钮
		private void SelectDifficulty()
		{
			switch (Difficulty)
			{
				case 1:
					LeftClick(904, 487); // 简单
					break;

				case 2:
					LeftClick(904, 617); // 普通
					break;

				default:
					LeftClick(904, 752); // 困难
					break;
			}
		}
	}
}

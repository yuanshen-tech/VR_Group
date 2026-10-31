Console.CursorVisible = false;
int w = 50, h = 30;
Console.SetWindowSize(w, h);
Console.SetBufferSize(w, h);
int nowSceneID = 1;
while (true)
{
	switch (nowSceneID)
	{
		case 1:
			Console.Clear();
			//开始场景
			#region 开始场景
			Console.SetCursorPosition(w / 2 - 7, 6);
			Console.Write("nanami营救社长");
			int nowChose = 0;
			while (true)
			{
				bool quiteWhile = false;
				Console.SetCursorPosition(w / 2 - 4, 9);
				Console.ForegroundColor = nowChose == 0 ? ConsoleColor.Red : ConsoleColor.White;
				Console.Write("开始游戏");
                Console.SetCursorPosition(w / 2 - 4, 11);
                Console.ForegroundColor = nowChose == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("结束游戏");
				Console.SetCursorPosition(w / 2 - 5, h - 1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("按空格继续");
				char input = Console.ReadKey(true).KeyChar;
				switch (input)
				{
					case 'W':
					case 'w':
						nowChose = 0;
						break;
					case 'S':
					case 's':
						nowChose = 1;
						break;
					case ' ':
						if (nowChose == 0)
						{ 
							nowSceneID = 2;
							quiteWhile = true;
						}
						else
							Environment.Exit(0);
						break;
				}
				if (quiteWhile == true)
					break; 
			}
			break;
            #endregion
        case 2:
            Console.Clear();
            //游戏场景
            #region 红墙
			Console.ForegroundColor= ConsoleColor.Red;
			//横墙
			for (int i = 0; i < w; i += 2)
			{
				Console.SetCursorPosition(i, 0);
				Console.Write("■");
                Console.SetCursorPosition(i, h - 1);
                Console.Write("■");
                Console.SetCursorPosition(i, h - 6);
                Console.Write("■");
            }
			//竖墙
			for (int i = 0; i < h; i++)
			{
				Console.SetCursorPosition(0, i);
				Console.Write("■");
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }
            #endregion

            #region BOSS
			int bossX = 24, bossY = 15, bossATKmin = 7, bossATKmax = 13, bossHP = 100;
			string bossIcon = "■";
			ConsoleColor bossColor = ConsoleColor.Green;
            #endregion
            while (true)
			{
				if (bossHP > 0)
				{
					Console.SetCursorPosition(bossX, bossY);
					Console.ForegroundColor = bossColor;
					Console.Write(bossIcon);
				}
			}
            break;
		case 3:
            Console.Clear();
            //结束场景
            break;
	}
}

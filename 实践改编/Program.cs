Console.CursorVisible = false;
int w = 50, h = 30;
Console.SetWindowSize(w, h);
Console.SetBufferSize(w, h);
int nowSceneID = 1;
bool spical = false;
while (true)
{
    switch (nowSceneID)
    {
        case 1:
            Console.Clear();
            //开始场景
            #region 开始场景
            Console.SetCursorPosition(w / 2 - 4, 6);
            Console.Write("营救社长");
            int nowChose = 0;
            char input;
            while (true)
            {
                bool quiteWhile = false;
                Console.SetCursorPosition(w / 2 - 8, 9);
                Console.ForegroundColor = nowChose == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("什么!取我宝剑来!");
                Console.SetCursorPosition(w / 2 - 4, 11);
                Console.ForegroundColor = nowChose == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("懒得QAQ");
                Console.SetCursorPosition(w / 2 - 5, h - 1);
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("按空格继续");
                input = Console.ReadKey(true).KeyChar;
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
            Console.ForegroundColor = ConsoleColor.Red;
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
            //左竖墙
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
            }
            for (int i = 0; i <= 21; i++)
            {
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }
            for (int i=23; i <h; i++)
            {
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }
            Console.SetCursorPosition(w - 2, 22);
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.Write("■");
            #endregion

            #region BOSS
            int bossX = 24, bossY = 15, bossATKmin = 7, bossATKmax = 13, bossHP = 100;
            string bossIcon = "■";
            ConsoleColor bossColor = ConsoleColor.Green;
            #endregion

            #region 角色相关
            int playerX = 4, playerY = 5, playerATKmin = 8, playerATKmax = 12, playerHP = 100;
            string playerIcon = "●";
            ConsoleColor playerColor = ConsoleColor.Yellow;
            //角色移动输入
            char playerInput;
            #endregion

            #region 社长相关
            int FX = 24, FY = 5;
            string FIcon = "◆";
            ConsoleColor FColor = ConsoleColor.Blue;
            #endregion

            #region 战斗相关
            bool isFight = false;
            bool isOver = false;
            #endregion
            while (true)
            {
                #region BOSS显示相关
                if (bossHP > 0)
                {
                    Console.SetCursorPosition(bossX, bossY);
                    Console.ForegroundColor = bossColor;
                    Console.Write(bossIcon);
                }
                #endregion
                #region 社长显示相关
                else
                {
                    Console.SetCursorPosition(FX, FY);
                    Console.ForegroundColor = FColor;
                    Console.Write(FIcon);
                }
                #endregion

                #region 角色相关及战斗
                if (playerHP > 0)
                {
                    Console.SetCursorPosition(playerX, playerY);
                    Console.ForegroundColor = playerColor;
                    Console.Write(playerIcon);
                }
                playerInput = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("  ");
                if (isFight == true)
                {
                    #region 战斗状态
                    if (playerInput == ' ')
                    {
                        if (playerHP <= 0)
                        {
                            nowSceneID = 3;
                            break;
                        }
                        else if (bossHP <= 0)
                        {
                            Console.SetCursorPosition(bossX, bossY);
                            Console.Write("  ");
                            isFight = false;
                        }
                        else
                        {
                            Random r = new Random();
                            int atk;
                            if (spical == false)
                            {
                                atk = r.Next(playerATKmin, playerATKmax);
                                bossHP -= atk;
                                Console.SetCursorPosition(2, h - 4);
                                Console.Write("                                            ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(2, h - 4);
                                Console.Write("你对BOSS造成了{0}点伤害,BOSS剩余血量为{1}", atk, bossHP);
                            }
                            else
                            {
                                Console.SetCursorPosition(2, h - 4);
                                Console.Write("                                            ");
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.SetCursorPosition(2, h - 4);
                                Console.Write("奋力挥动\"神器\",滚木断掉了。。未对BOSS造成伤害");
                                spical = false;
                            }
                            if (bossHP > 0)
                            {
                                atk = r.Next(bossATKmin, bossATKmax);
                                playerHP -= atk;
                                Console.SetCursorPosition(2, h - 3);
                                Console.Write("                                            ");
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.SetCursorPosition(2, h - 3);
                                if (playerHP >= 0)
                                    Console.Write("BOSS对你造成了{0}点伤害,你的剩余血量为{1}", atk, playerHP);
                                else
                                {
                                    Console.Write("                                            ");
                                    Console.SetCursorPosition(2, h - 4);
                                    Console.Write("(来自BOSS的嘲讽QAQ)                         ");
                                    Console.SetCursorPosition(2, h - 5);
                                    Console.Write("很遗憾,你没打过BOSS,回家再练练吧              ");
                                }
                            }
                            else
                            {
                                Console.SetCursorPosition(2, h - 5);
                                Console.Write("                                            ");
                                Console.SetCursorPosition(2, h - 4);
                                Console.Write("                                            ");
                                Console.SetCursorPosition(2, h - 3);
                                Console.Write("                                            ");
                                Console.SetCursorPosition(2, h - 5);
                                Console.Write("你战胜了BOSS,快去营救社长！！");
                                Console.SetCursorPosition(2, h - 4);
                                Console.Write("前往社长旁边,按下空格营救");
                            }
                        }
                    }
                    #endregion
                }
                else
                {
                    #region 非战斗状态
                    if (bossHP > 0)
                    {
                        Console.SetCursorPosition(2, h - 5);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("靠近BOSS，按下空格进行战斗！！");
                        Console.SetCursorPosition(2, h - 4);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (spical == false)
                            Console.Write("玩家的血量为{0},攻击为{1}～{2}", playerHP, playerATKmin, playerATKmax);
                        else
                            Console.Write("玩家的血量为{0},攻击力达9999！！", playerHP);
                    }
                    switch (playerInput)
                    {
                        case 'W':
                        case 'w':
                            playerY--;
                            if (playerY < 1)
                                playerY = 1;
                            else if (playerX == bossX && playerY == bossY && bossHP > 0)
                                playerY++;
                            else if (playerX == FX && playerY == FY && bossHP <= 0)
                                playerY++;
                            break;
                        case 'A':
                        case 'a':
                            playerX -= 2;
                            if (playerX < 2)
                                playerX = 2;
                            else if (playerX == bossX && playerY == bossY && bossHP > 0)
                                playerX += 2;
                            else if (playerX == FX && playerY == FY && bossHP <= 0)
                                playerX += 2;
                            break;
                        case 'S':
                        case 's':
                            playerY++;
                            if (playerY > h - 7)
                                playerY = h - 7;
                            else if (playerX == bossX && playerY == bossY && bossHP > 0)
                                playerY--;
                            else if (playerX == FX && playerY == FY && bossHP <= 0)
                                playerY--;
                            break;
                        case 'D':
                        case 'd':
                            playerX += 2;
                            if (playerX > w - 4)
                                playerX = w - 4;
                            else if (playerX == bossX && playerY == bossY && bossHP > 0)
                                playerX -= 2;
                            else if (playerX == FX && playerY == FY && bossHP <= 0)
                                playerX -= 2;
                            break;
                        case ' ':
                            #region 判断是否进入战斗或营救社长
                            #region 战斗
                            if ((playerX == bossX && playerY == bossY - 1 ||
                                 playerX == bossX && playerY == bossY + 1 ||
                                 playerX == bossX - 2 && playerY == bossY ||
                                 playerX == bossX + 2 && playerY == bossY) && bossHP > 0)
                            {
                                isFight = true;
                                Console.SetCursorPosition(2, h - 5);
                                Console.Write("开始战斗！！按空格继续");
                                Console.SetCursorPosition(2, h - 4);
                                if (spical == false)
                                    Console.Write("玩家的血量为{0},攻击为{1}～{2}     ", playerHP, playerATKmin, playerATKmax);
                                else
                                    Console.Write("玩家的血量为{0},攻击为9999       ", playerHP);
                                Console.SetCursorPosition(2, h - 3);
                                Console.Write("BOSS的血量为{0},攻击为{1}～{2}     ", bossHP, bossATKmin, bossATKmax);
                            }
                            #endregion
                            #region 营救
                            else if ((playerX == FX && playerY == FY - 1 ||
                                      playerX == FX && playerY == FY + 1 ||
                                      playerX == FX - 2 && playerY == FY ||
                                      playerX == FX + 2 && playerY == FY) && bossHP <= 0)
                            {
                                nowSceneID = 4;
                                isOver = true;
                            }
                            #endregion
                            #region "神奇"的小木棍
                            else if(playerX == w-4 && playerY == 22 && spical == false)
                            {
                                nowSceneID = 5;
                                isOver = true;
                            }
                            else if(playerX == w - 4 && playerY == 22)
                            {
                                Console.SetCursorPosition(2, h - 3);
                                if(spical == true)
                                    Console.Write("已经拿到\"神器\"了,不用再去了");
                                else if(bossHP <= 0)
                                    Console.Write("BOSS的尸体倒在了这里，无法前往");
                            }
                            #endregion
                            #endregion
                            break;
                    }
                    #endregion
                }
                #endregion
                if (isOver == true)
                    break;
            }
            break;
        case 3:
            Console.Clear();
            //死亡场景
            #region 死亡场景
            Console.SetCursorPosition(w / 2 - 15, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("坏结局:社长被BOSS抓走诶嘿嘿嘿去了");
            Console.SetCursorPosition(w - 14, h - 1);
            Console.Write("(还有中国人寿)");
            int dieChose = 0;
            char dieInput;
            while (true)
            {
                bool quiteDiewhile = false;
                Console.SetCursorPosition(w / 2 - 4, 9);
                Console.ForegroundColor = dieChose == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("我不服气");
                Console.SetCursorPosition(w / 2 - 3, 11);
                Console.ForegroundColor = dieChose == 1 ? ConsoleColor.Green : ConsoleColor.White;
                Console.Write("我服了");
                dieInput = Console.ReadKey(true).KeyChar;
                switch (dieInput)
                {
                    case 'W':
                    case 'w':
                        dieChose = 0;
                        break;
                    case 'S':
                    case 's':
                        dieChose = 1;
                        break;
                    case ' ':
                        if (dieChose == 0)
                        {
                            nowSceneID = 2;
                            quiteDiewhile = true;
                        }
                        else
                            Environment.Exit(0);
                        break;
                }
                if (quiteDiewhile == true)
                    break;
            }
            break;
            #endregion
        case 4:
            Console.Clear();
            //胜利场景
            #region 胜利场景
            Console.SetCursorPosition(w / 2 - 15, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("好结局:和社长过上了没羞没躁的生活");
            int overChose = 0;
            char overInput;
            while (true)
            {
                bool quiteOverwhile = false;
                Console.SetCursorPosition(w / 2 - 5, 9);
                Console.ForegroundColor = overChose == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("返回主菜单");
                Console.SetCursorPosition(w / 2 - 4, 11);
                Console.ForegroundColor = overChose == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("退出游戏");
                overInput = Console.ReadKey(true).KeyChar;
                switch (overInput)
                {
                    case 'W':
                    case 'w':
                        overChose = 0;
                        break;
                    case 'S':
                    case 's':
                        overChose = 1;
                        break;
                    case ' ':
                        if (overChose == 0)
                        {
                            nowSceneID = 1;
                            quiteOverwhile = true;
                        }
                        else
                            Environment.Exit(0);
                        break;
                }
                if (quiteOverwhile == true)
                    break;
            }
            break;
            #endregion
        case 5:
            Console.Clear();
            //神秘房间

            #region 红墙
            Console.ForegroundColor = ConsoleColor.Red;
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
            //左竖墙
            for (int i = 0; i < h; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
            }
            for (int i = 0; i <= 21; i++)
            {
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }
            for (int i = 23; i < h; i++)
            {
                Console.SetCursorPosition(w - 2, i);
                Console.Write("■");
            }
            Console.SetCursorPosition(w - 2, 22);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("■");
            #endregion

            #region 角色相关
            playerIcon = "●";
            playerColor = ConsoleColor.Yellow;
            playerX = w - 4;
            playerY = 22;
            //角色移动输入
            char nowplayerInput;
            #endregion

            #region 字幕显示
            Console.SetCursorPosition(2, h - 5);
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.Write("恭喜你发现隐藏房间！！");
            #endregion

            #region 滚木相关
            int gunMuX = 24, gunMuY = 5;
            string gunMuIcon = "∕";
            ConsoleColor gunMuColor = ConsoleColor.Blue;
            //拾取
            bool ishave = false;
            #endregion

            #region 滚木获取
            isOver = false;
            while (true)
            {
                if (ishave == false)
                {
                    Console.SetCursorPosition(gunMuX, gunMuY);
                    Console.ForegroundColor = gunMuColor;
                    Console.Write(gunMuIcon);
                }
                else
                {
                    Console.SetCursorPosition(2, h - 4);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("获得\"神秘\"小木棍(滚木？！)");
                    Console.SetCursorPosition(2, h - 3);
                    Console.Write("攻击力\"增加\"了9999！！");
                }
                Console.SetCursorPosition(playerX, playerY);
                Console.ForegroundColor = playerColor;
                Console.Write(playerIcon);
                nowplayerInput = Console.ReadKey(true).KeyChar;
                Console.SetCursorPosition(playerX, playerY);
                Console.Write("  ");
                switch (nowplayerInput)
                {
                    case 'W':
                    case 'w':
                        playerY--;
                        if (playerY < 1)
                            playerY = 1;
                        else if (playerX == gunMuX && playerY == gunMuY && ishave == false)
                            playerY++;
                        break;
                    case 'A':
                    case 'a':
                        playerX -= 2;
                        if (playerX < 2)
                            playerX = 2;
                        else if (playerX == gunMuX && playerY == gunMuY && ishave == false)
                            playerX += 2;
                        break;
                    case 'S':
                    case 's':
                        playerY++;
                        if (playerY > h - 7)
                            playerY = h - 7;
                        else if (playerX == gunMuX && playerY == gunMuY && ishave == false)
                            playerY--;
                        break;
                    case 'D':
                    case 'd':
                        playerX += 2;
                        if (playerX > w - 4)
                            playerX = w - 4;
                        else if (playerX == gunMuX && playerY == gunMuY && ishave == false)
                            playerX -= 2;
                        break;
                    case ' ':
                        if((playerX == gunMuX && playerY == gunMuY - 1 ||
                            playerX == gunMuX && playerY == gunMuY + 1 ||
                            playerX == gunMuX - 2 && playerY == gunMuY ||
                            playerX == gunMuX + 2 && playerY == gunMuY) && ishave == false)
                        {
                            ishave = true;
                            spical = true;
                            Console.SetCursorPosition(gunMuX, gunMuY);
                            Console.Write("  ");
                            break;
                        }
                        else if(playerX == w - 4 && playerY == 22)
                        {
                            nowSceneID = 2;
                            isOver = true;
                        }
                        break;
                }
                if (isOver == true)
                    break;
            }
            break;
            #endregion
    }
}
Console.CursorVisible = false;
int w = 50;
int h = 30;
Console.SetWindowSize(w, h);
Console.SetBufferSize(w, h);
int NowSceneID = 1;
while(true)
{
    switch (NowSceneID )
    {    //开始场景
        case 1:
            Console.Clear();
            Console.SetCursorPosition(w / 2 - 7,  8);
            Console.Write("靳昊林营救学姐");
            //根据当前选择的编号来决定是否变色
            int nowSelIndex = 0;
            while (true)
            {
                bool isQuitWhile = false;
                Console.SetCursorPosition(w / 2 - 4, 13);
                if (nowSelIndex == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("开始游戏");
                Console.SetCursorPosition(w / 2 - 4, 15);
                if (nowSelIndex == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("结束游戏");
                char input = Console.ReadKey(true).KeyChar;
                switch (input)
                {
                    case 'w':
                    case 'W':
                        --nowSelIndex;
                        if (nowSelIndex < 0)
                        {
                            nowSelIndex = 0;
                        }
                        break;
                    case 's':
                    case 'S':
                        ++nowSelIndex;
                        if (nowSelIndex > 1)
                        {
                            nowSelIndex = 1;
                        }
                        break;
                    case 'j':
                    case 'J':
                        if (nowSelIndex == 0)
                        {
                            //1.要改变当前选择的场景id
                            //2.要退出内层while循环
                            nowSelIndex = 2;
                            isQuitWhile = true;

                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;




                }






        case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    for (int i = 0; i <= w - 2; i += 2)
                    {
                        Console.SetCursorPosition(i, 0);
                        Console.Write("■");
                    }
                    for (int i = 0; i < w; i += 2)
                    {
                        Console.SetCursorPosition(i, h - 1);
                        Console.Write("■");

                    }
                    for (int i = 0; i < w; i += 2)
                    {
                        Console.SetCursorPosition(i, h - 6);
                        Console.Write("■");

                    }
                    for (int i = 0; i < w; i += 2)
                    {
                        Console.SetCursorPosition(0, i);
                        Console.Write("■");

                    }
                    for (int i = 0; i < w; i += 2)
                    {
                        Console.SetCursorPosition(i, w - 2);
                        Console.Write("■");

                    }
                    int bossX = 24;
                    int bossY = 15;
                    int bossATKMin = 7;
                    int bossATKMax = 13;
                    int bossHp = 100;
                    string bossIcon = "■";
                    ConsoleColor bossColor = ConsoleColor.Green;
                    //玩家相关
                    int playerX = 4;
                    int playerY = 5;
                    int playerAtkMin = 8;
                    int playerAtkMax = 12;
                    int playerHp = 100;
                    string playerIcon = "●";
                    ConsoleColor playerColor = ConsoleColor.Yellow;
                    char playerinput;
                    bool isFight=false;
                    while (true)
                    {
                        if (bossHp > 0)
                        {


                            Console.SetCursorPosition(bossX, bossY);
                            Console.ForegroundColor = bossColor;
                            Console.Write(bossIcon);


                        }
                        Console.SetCursorPosition(playerX, playerY);
                        Console.ForegroundColor = playerColor;
                        Console.Write(playerIcon);
                        playerinput = Console.ReadKey(true).KeyChar;
                        if(isFight )
                        {
                            if(playerinput =='J'||playerinput =='j')
                            {
                                if(playerHp<=0)
                                {

                                    NowSceneID = 3;
                                    break;
                                }
                                else if (bossHp <=0)
                                {
                                    Console .SetCursorPosition (bossX, bossY);
                                    Console .Write ("  ");
                                    isFight = false ;
                                }
                                else
                                {
                                    Random r = new Random();
                                    int atk = r.Next(playerAtkMin, playerAtkMax);
                                    bossHp -= atk;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.SetCursorPosition(2, h - 4);
                                    Console.Write("                                                    ");
                                    Console.SetCursorPosition(2, h - 4);
                                    Console.Write("你对boss造成{0}点伤害，boss剩余血量{1}", atk, bossHp);
                                    if (bossHp > 0)
                                    {
                                        atk = r.Next(bossATKMin, bossATKMax);
                                        playerHp -= atk;
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.SetCursorPosition(2, h - 3);
                                        Console.Write("                                                    ");

                                        if (playerHp <= 0)
                                        {
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("很遗憾，你未能通过boss的试炼，战败了");
                                        }
                                        else
                                        {
                                            Console.SetCursorPosition(2, h - 3);
                                            Console.Write("booss对你造成{0}点伤害，你剩余血量{1}", atk, playerHp);
                                        }

                                    }
                                    else
                                    {
                                        Console.SetCursorPosition(2, h - 5);
                                        Console.Write("                                                    ");
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("                                                    ");
                                        Console.SetCursorPosition(2, h - 3);
                                        Console.Write("                                                    ");
                                        Console.SetCursorPosition(2, h - 5);
                                        Console.Write("你战胜了boss,快去营救公主");
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("前往公主身边，按j键继续");

                                    }

                                }



                               
                            }
                        }
                        else
                        {

                            Console.SetCursorPosition(playerX, playerY);
                            Console.Write("  ");
                            switch (playerinput)
                            {
                                case 'W':
                                case 'w':
                                    --playerY;
                                    if (playerY < 1)
                                    {
                                        playerY = 1;
                                    }
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                    {
                                        ++playerY;
                                    }
                                    break;
                                case 'A':
                                case 'a':
                                    playerX -= 2;
                                    if (playerX < 2)
                                    {
                                        playerX = 2;
                                    }
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                    {
                                        playerX += 2;
                                    }
                                    break;
                                case 's':
                                case 'S':
                                    ++playerY;
                                    if (playerY > h - 7)
                                    {
                                        playerY = h - 7;
                                    }
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                    {
                                        --playerY;
                                    }
                                    break;
                                case 'd':
                                case 'D':
                                    playerX += 2;
                                    if (playerX < w - 2)
                                    {
                                        playerX = w - 2;
                                    }
                                    else if (playerX == bossX && playerY == bossY && bossHp > 0)
                                    {
                                        playerX -= 2;
                                    }
                                    break;
                                case 'j':
                                case 'J':
                                    if ((playerX == bossX && playerY == bossY - 1 || playerX == bossX && playerY == bossY + 1 || playerX == bossX - 2 && playerY == bossY || playerX == bossX + 2 && playerY == bossY) && bossHp > 0)
                                    {
                                        isFight = true;
                                        Console.SetCursorPosition(2, h - 5);
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.Write("开始和boss战斗了，按j键继续");
                                        Console.SetCursorPosition(2, h - 4);
                                        Console.Write("玩家当前的血量为{0}", playerHp);
                                        Console.SetCursorPosition(2, h - 3);
                                        Console.Write("boss当前的血量为{0}", bossHp);

                                    }
                                    break;

                            }
                            break;


                        }
                        
                    }
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("结束场景");
                    break;






                }
            }

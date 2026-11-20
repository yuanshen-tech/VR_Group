namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("practice!");
            //需求分析
            //开始界面
            //显示 控制台输出
            //输入
            //颜色变化
            //循环
            //按键变化颜色

            //游戏界面
            //控制台输入输出
            //颜色界面
            //switch while
            //条件判断 if语句
            //回合制战斗 随机数 循环 if语句

            //结束界面
            //类似与开始界面

            //界面之间的相互切换
            #region 控制台基础设置
            //通过两个变量来存储信息 只用改一次
            int w = 50;
            int h = 30;
            //控制台窗口大小
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);
            //隐藏光标
            Console.CursorVisible = false;
            #endregion

            #region 多个场景
            int nowSceneID = 0;
            while (true)
            {
                //不同的场景ID 进行不同的逻辑处理
                switch (nowSceneID)
                {
                    //开始场景
                    case 0:
                        Console.Clear();
                        Console.SetCursorPosition(w / 2 - 6, 10);
                        Console.Write("骑士营救公主");
                        //当前选项编号
                            int nowSelIndex = 0;
                        while(true)
                        { 
                            bool isquitwhile = false;
                            Console.SetCursorPosition(w / 2 - 4, 20);
                            Console.ForegroundColor = nowSelIndex==0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("开始游戏");
                            
                            Console.SetCursorPosition(w / 2 - 4, 22);
                            Console.ForegroundColor = nowSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {//先设置光标位置再显示内容
                                case 'w':
                                case 'W':
                                    
                                    if(nowSelIndex == 1) nowSelIndex = 0;else nowSelIndex = 1;
                                    break;
                                case 's':
                                case 'S':
                                    if (nowSelIndex == 1) nowSelIndex = 0; else nowSelIndex = 1;
                                    break;
                                case ' ':
                                case 'j':
                                case 'J':
                                    if (nowSelIndex == 1)
                                    {
                                        Environment.Exit(0);
                                    }
                                    else
                                    {
                                        isquitwhile = true;
                                        nowSelIndex = 0;
                                    }
                                    break;

                            }

                            if (isquitwhile == true) break;
                        }

                        nowSceneID = 1;
                        break;
                    //游戏场景
                    case 1:
                        Console.Clear();
                        Console.WriteLine("游戏场景");

                        //nowSceneID = 2;
                        break;
                    //结束场景
                    case 2:
                        Console.Clear();
                        Console.WriteLine("结束场景");
                        nowSceneID = 0;
                        break;


                }

            #endregion

            }
        }
    }
}

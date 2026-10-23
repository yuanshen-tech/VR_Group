using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控制台相关
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 控制台相关
            //输出
            //Console.WriteLine("123123");//光标不空行
            //Console.Write("123123123123");//不空行

            //输入
            //string str = Console.ReadLine();
            //注意：如果在ReadKey()的括号中加上true，则不会把输入的内容显示在控制台上
            //char c = Console.ReadKey(true).KeyChar;
            //Console.WriteLine(c);

            //清空
            //Console.Clear();

            //设置控制台大小
            //控制台大小分为窗口大小和缓冲区大小
            //注意：1.先设置窗口大小，再设置缓冲区大小
            //2.缓冲区的大小不能小于窗口的大小
            //3.窗口的大小不能大于控制台的最大尺寸
            //窗口大小
            //Console.SetWindowSize(100,50);
            //缓冲区大小
            //Console.SetBufferSize(1000,1000);

            //设置光标的位置
            //控制台左上角为原点(0,0)，右侧是x轴正方向，下方是y轴正方向，它是一个平面二维坐标系
            //注意：1.边界问题
            //2.横纵边距单位不同 视觉上1y=2x//中文符号在控制台
            //Console.SetCursorPosition(10,5);
            //Console.WriteLine("123123");

            //设置颜色相关
            //文字颜色设置
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("123123");
            //背景颜色设置
            //Console.BackgroundColor = ConsoleColor.White;
            //重置背景颜色过后需要Clear一次才能把整个背景颜色改变
            //Console.Clear();

            //光标显隐
            //Console.CursorVisible = false;//false为隐藏，true为显示

            //关闭控制台
            //Environment.Exit(0);

            #endregion

            #region 控制台相关练习题
            //Q1
            //int x=0, y=0;
            //Console.CursorVisible = false;
            //while (true)
            //{
            //    Console.BackgroundColor = ConsoleColor.Red;
            //    Console.Clear();
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.SetCursorPosition(x,y);
            //    Console.WriteLine("■");//中文输入法输入v1可以寻找到方块
            //    char a = Console.ReadKey(true).KeyChar;
            //    switch (a)
            //    {
            //        case 'A':
            //        case 'a':
            //            x -= 2;
            //            break;
            //        case 'D':
            //        case 'd':
            //            x += 2;
            //            break;
            //        case 'W':
            //        case 'w':
            //            y -= 1;
            //            break;
            //        case 'S':
            //        case 's':
            //            y += 1;
            //            break;
            //    }
            //}

            //答案
            //改变背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //改变字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;
            //设置位置信息
            int x = 0, y = 0;
            //隐藏光标
            Console.CursorVisible = false;
            while (true)
            {
                //第一种清空之前信息的方式
                //Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.WriteLine("■");
                //得到玩家的输入信息，隐藏输入内容
                char a = Console.ReadKey(true).KeyChar;
                //把之前的方块擦掉了
                Console.SetCursorPosition(x, y);
                Console.WriteLine("  ");
                switch (a)
                {
                    //贯穿
                    case 'W':
                    case 'w':
                        y -= 1;
                        //考虑边界问题，改变位置过后需要判断是否越界
                        if (y<0)
                        {
                            y = 0;
                        }
                        break;
                    case 'A':
                    case 'a':
                        //中文符号在控制台上占两个位置
                        x -= 2;
                        if (x < 0)
                        {
                            x = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        y += 1;
                        if (y > Console.BufferHeight-1)
                        {
                            y = Console.BufferHeight-1;
                        }
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if (x > Console.BufferWidth-2)
                        {
                            x = Console.BufferWidth-2;
                        }
                        break;
                }
            }




            #endregion

        }

    }
}

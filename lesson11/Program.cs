using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;


namespace 控制台相关
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //背景颜色
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //nsole.WriteLine("控制台相关");
            //readkey(true)不会吧输入的内容显示在控制台上
            //char c = Console.ReadKey(true).KeyChar;
            //Console.WriteLine(c);

            #region 控制台其他方法
            //清空 
            Console.Clear();

            //设置控制台大小
            //窗口大小 缓冲区大小
            //注意：先设置窗口再缓冲区
            //缓冲区小于窗口小于控制台最大尺寸(分辨率)
            Console.SetWindowSize(100, 50);
            //缓冲区 可以打印的区域的宽高
            Console.SetBufferSize(1000, 1000);

            //设置光标的位置
            //左上角为(0,0) 右侧为x轴正方形 下侧为y轴正方向
            //边界问题
            //1y=2x视觉中横纵坐标方向不同
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("123");

            //设置颜色相关
            //文字颜色设置
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("123");
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("123");
            //背景颜色
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            //光标显隐
            Console.CursorVisible = false;

            //关闭控制台
            Environment.Exit(0);
            #endregion
        }
    }
}
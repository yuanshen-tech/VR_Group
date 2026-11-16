using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;


namespace array1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 递归函数
            //让函数自己调用自己
            //static void Fun()
            //{
            //    Fun();
            //}
            //正确的递归函数
            //必须有结束调用的条件
            //用于条件判断的条件必须改变 能够达到停止的目的

            //for example
            //用递归函数打印出0到10
            static void Fun(int a)
            {   if(a>10)
                {
                    return;
                }
                Console.WriteLine(a);
                ++a;
                Fun(a);
            }

            Fun(0);
            #endregion
            int i = 1;
            #region 阶乘
            static void Factorial(int a ) 
            {
                Console.Write(a);
                a--;
                if (a < 1)
                {
                    return;
                }
                else
                {   Console.Write("*");
                    Factorial(a);
                }
            }

            string  a = Console.ReadLine();
            Console.Write(a+"!=");
            Factorial(5);
            #endregion

        }
    }
}
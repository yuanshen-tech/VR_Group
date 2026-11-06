using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 数据类型，分两种
            // 1.值类型
            // 整数或负数：short,int,long
            // 小数：float,double
            // 布尔：bool，Boolean
            // 数组：[]

            #region 整数或负数

            // short 最大值为32767
            short i3 = 0;

            // int的最大值和最小值 为 21亿 或 -21亿
            int i = 0;
            int i2 = -1;

            // 超过21亿，考虑用long类型
            long l = 21111111111;

            #endregion

            #region 小数

            // 大概率用不上
            float f = 0.1f;

            // 最常用
            double d = 0.2;

            double d2 = 100;

            // double 最大值，非常非常大，如果int不满足使用，可考虑用double兼容
            // double兼容int,可存储 小数与整数

            //double.MaxValue

            #endregion

            #region 布尔

            bool b1 = true;
            bool b2 = false;

            bool b3 = 1 > 3; // false
            bool b4 = 3 > 1; // true

            #endregion

            // 2.引用类型 string,char

            #region 字符串类型

            // 字符串类型，可以存储一长串的文本
            string str = "adqwedqrahid123123";

            #endregion

            #region 字符类型

            // char 字符类型，只能存储单个字符
            char c = 'a';

            #endregion



        }
    }
}

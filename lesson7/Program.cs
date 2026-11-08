using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;


namespace lesson6;

internal class Program
{
    #region 基本概念
    //在同一语句块中
    //函数名相同
    //参数数量相同 但参数的类型和顺序不同

    //作用 可以减少函数名的数量 避免命名空间的污染
    //调用时 程序会根据自己传进去的参数类型判断使用哪一个重载
    static int CalcSum(int a, int b)
    {
        return a + b;
    }
    //参数数量不同
    static int CalcSum(int a,int b, int c)
    {
        return a + b + c;
    }
    //数量相同类型不同
    static float CalcSum(float a,float b)
    {
        return a + b;
    }
    static float CalcSum(int a, float b)
    {
        return a + b;
    }
    //数量相同顺序不同
    static float CalcSum(float a, int b)
    {
        return a + b;
    }
    //summary 同一语句块 函数名相同 数量顺序类型不同的函数
    //作用一般用来处理不同参数的同一类型逻辑运算
    #endregion
    private static void Main(string[] args)
    {
        Console.WriteLine(CalcSum(1, 2));
        Console.WriteLine(CalcSum(2, 3,4));
        Console.WriteLine(CalcSum(1.2f, 2.5f));
        Console.WriteLine(CalcSum(1, 2.5f));
    }
}
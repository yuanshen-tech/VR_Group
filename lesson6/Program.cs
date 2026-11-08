using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;


namespace lesson6;

internal class Program
{
    #region 函数语法复习
    //static void 函数名(参数类型 参数1,参数类型 参数2) 
    #endregion

    #region 变长参数关键字
    //for example calculate n sum of int
    //static int Sum(int a, int b,......)

    //变长参数关键字 params
    static int Sum(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum;
    }
    //params int[] 意味着可以传入n个int的参数
    //params后面只能是数组 所以必须是同一类型
    #endregion

    #region 参数默认值
    //有参数默认值的一般为可选参数
    //作用是 当调用函数时不传入函数 不传参数就会以默认值运行
    static void Speak(string str="Hello,World!") 
    { 
        Console.WriteLine(str);
    }
    //支持多参数默认值 每个参数都可以有默认值
    //如果要混用 可选参数必须写在普通参数后面 不然计算机不知道你后面传的参数是给谁的
    static void Speak2(string test, string name = "hhh", string str = "我没什么话说") { }
    #endregion
    private static void Main(string[] args)
    {
        Console.WriteLine("变长参数");
        Sum(1, 2, 3, 4, 5, 6);

        //params 后面必须是数组
        //函数参数中最多出现一个params关键字 并且一定是在最后一组参数 前面可以有n个其他参数
        static void Eat(string a ,params string[] things) 
        { 

        }
        Speak();
        Speak("你好啊世界！");

    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;


namespace lesson5;

internal class Program
{
    #region 学习ref和out的原因
    //可以解决函数内部改变外部传入的内容 里面变了外面也要变
    static void ChangeValue(int value)
    {
        value = 3;
    }
    static void ChangeArrayValue(int[] arr)
    {
        arr[0] = 99;
    }

    #endregion
    #region ref和out的使用
    static void ChangeValueRef(ref int value)
    {
        value = 3;
    }
    static void ChangeArrayValueRef(ref int[] arr)
    {
         arr=new int[] {11 };
    }

    #endregion
    private static void Main(string[] args)
    {
        int a = 1;
        ChangeValue(a);
        Console.WriteLine(a);
        
        ChangeValueRef(ref a);
        Console.WriteLine(a);

        int[] arr2 = { 1, 2, 3 };
        ChangeArrayValue(arr2);
        Console.WriteLine(arr2[0]);

        int[] arr4 = { 1, 2, 3 };
        ChangeArrayValueRef(ref arr4);
        Console.WriteLine(arr4[0]);
        #region 区别

        //ref使用的时候必须要chushih out不用
        //out传入的内容必须在内部赋值 ref不用
        #endregion
    }

}
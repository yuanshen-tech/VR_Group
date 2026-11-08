using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;


namespace lesson4;

internal class Program
{
    private static void Main(string[] args)
    {
        #region 函数在哪
        //只能写在class语句块内或者struck语句块内
        #endregion
        #region 基本语法
        // 1           2      3
        //static   返回类型 函数名 (参数类型 参数名1, 参数类型 参数名2...)
        //{函数代码逻辑;
        //  return 返回值;  
        //}
        //static 在没有学习类和结构体之前是必须写的

        //void 没有返回值
        //返回类型可以写任意变量类型

        //命名 帕斯卡命名法  MyName

        //参数不是必须的 参数名 驼峰命名法 myName

        //当返回类型不是void 必须return返回内容 (void也可以选择性使用)
        #endregion
        #region 实际运用
        //无参数无返回值
        static void SayHellow()
        {
            Console.WriteLine("你好世界");
                }
        //有参无返回值
        static void SayYourName(string name)
        {
            Console.WriteLine("你的名字是：{0}", name);
        }
        //无参有返回值
        //有返回值一般都要直接用
        static string WhatYourName()
         {
            return "tanglaoshi";
        }
        //有参有返回值  
        static int sum(int a, int b)
        { 
          //int c = a + b;
            return a + b;
        }
        //有参有多返回值
        //用数组作为返回值必须知道数组规则
        static float[] Calc(float a, float b)
        {
            float sum = a + b;
            float ave = sum / 2.0f;
               float[] arr = { sum,ave};
               return arr;
            //return new int[] {sum, ave };
        }
        #endregion
        #region 关于return
        static void Speak(string str)
        {
            if (str == "脏话")
            {
                return ;
            }
            Console.WriteLine(str);
        }

        #endregion

        Console.WriteLine("函数");
        //使用函数 直接写函数名(参数)
        SayHellow();
        SayYourName("yjj");

        SayYourName(WhatYourName());
        Console.WriteLine(sum(4, 5));
        float[] arr = Calc(4, 5);
        Console.WriteLine(arr[0] + " " + arr[1]);
        Speak("脏话");
        Speak("111");
    }
}
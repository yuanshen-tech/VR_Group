namespace _999
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——隐式转换");
            //什么是类型转换

            //类型转换 就是不同变量类型之间的相互转换

            //隐式转换的基本规则——>不同类型之间自动转换
            //大范围装小范围

            #region 知识点一 相同大类型之间的转换

            //有符号 long int short sbyte
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte sb = 1;
            //隐式转换 int隐式转换换成了long
            //可以用大范围 装小范围的 类型 （隐式转换）
            l = i;
            //不能够用小范围的类型去装大范围的类型
            //i = l; 
            l = i;
            l = s;
            l = sb;
            i = s;
            s = sb;

            //浮点数 decimal double float
            decimal de = 1.1m;
            double d = 1.1;
            float f = 1.1f;
            //demical 这个类型 没有办法用隐式转换去存储 double和float
            //de = d;
            //de = f;
            //float 可以隐式转换成 double
            d = f;

            //特殊类型 bool char string
            //他们之间 不存在隐式转换
            bool bo = true;
            char c = 'A';
            string str = "123123";

            #endregion

            #region  知识点二 不同大类型之间的转换

            #region 无符号和有符号之间
            //无符号
            byte b2 = 1;
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号
            //有符号的变量 是不能够隐式转换成无符号的
            //b2 = sb2;

            //有符号装无符号
            //有符号的变量 是能装无符号变量的前提是范围一定要是涵盖的 存在隐式转换
            //i2 = ui2; //因为 有符号的变量 可能会超过 这个五符号变量的范围
            i2 = b2;// 因为 有符号的变量 不管是多少 都在无符号变量范围内
            #endregion

            #region 浮点数和整数 （有，无符号） 之间
            //浮点数装整数
            float f2 = 1.1f;
            double d2 = 1.1;
            decimal de2 = 1.1m;

            //浮点数 是可以装载任何类型的 整数的

            //decimal 不能隐式储存 float和double
            //但是它可以隐式的储存整形

            //double——>float——>所有整形（无符号,有符号）
            //decimal——>所有整形（无符号，有符号）

            //整数装浮点数 整数是不能隐式存储 浮点数 因为 整数不能存小数

            #endregion

            #region 特殊类型和其他类型之间
            //bool bool没有办法和其他类型相互隐式转换
            #endregion


            #endregion

            //总结 隐式转换 规则
            //高精度 （大范围）装低精度（小范围）
            //double——>float——>整数（无符号，有符号）——> char
            //desimal——>
        }
    }
}

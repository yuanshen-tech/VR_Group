namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——显示转换");

            //显示转换——>手动处理 强制转换

            #region 知识点一 括号强转
            //作用 一般情况下 将高精度的类型强制转换成低精度
            //语法： 变量类型 变量名 = （变量类型）变量
            //注意： 精度问题 范围问题

            //相同大类的整形
            //有符号整型
            sbyte sb = 1;
            short s = 1;
            int i = 40000;
            long l = 1;

            //括号强转 可能会出现范围问题 造成的异常
            s = (short)i;
            Console.WriteLine(s);

            i = (int)1;
            sb = (sbyte)s;
            sb = (sbyte)i;
            sb = (sbyte)l;

            //无符号整型
            byte b = 1;
            uint ui = 1;
            b = (byte)ui;

            //浮点之间
            float f = 1.1f;
            double d = 1.123456789123456789f;

            f = (float)d;
            Console.WriteLine(f);

            //无符号和有符号
            uint ui2 = 1;
            int i2 = -1;
            //再强转换时 一定要注意范围 不然得不到结果 可能有异常 
            ui2 = (uint)i2;
            Console.WriteLine(ui2);

            //浮点和整形 浮点数强转换成整形时 会直接抛弃小数点后面的小数
            i2 = (int)1.24f;
            Console.WriteLine(i2);

            //char和数值类型
            i2 = 'A';

            char c = (char)i2;
            Console.WriteLine(c);
            #endregion

            #region 知识点二 Parse法

            #endregion

            #region 知识点三 Convert法

            #endregion

            #region 知识点四 其他类型转string

            #endregion
        }
    }
}

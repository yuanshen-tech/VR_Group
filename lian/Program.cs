namespace lian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获练习");

            #region 练1
            //请用户输入一个数字
            //如果输入有误 则提示用户输入错误
            try
            {
                string str = Console.ReadLine();
                long l = long.Parse(str);
                Console.WriteLine("你输入的数字为：" + l);
            }
            catch
            {
                Console.WriteLine("您的输入有误");
            }
            #endregion

            #region 练2
            //提示用户输入姓名、语文、数学、英语成绩
            //如果用户输入的成绩有误，则提示用户输入错误
            //否则将输入的字符串转为整形变量存储
            try
            {
                Console.WriteLine("请输入用户名");
                string yourname = Console.ReadLine();
                Console.WriteLine("请输入语文成绩");
                string yuwenstr = Console.ReadLine();
                int yuwen = int.Parse(yuwenstr);
                Console.WriteLine("请输入数学成绩");
                string shuxuestr = Console.ReadLine();
                int shuxue = int.Parse(shuxuestr);
                Console.WriteLine("请输入英语成绩");
                //一步到位的写法
                int yingyu = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("您的输入不合法，成绩请输入数字");
            }
            //可以用多个try catch 第一个错误不影响后面的输入
            #endregion
        }
    }
}

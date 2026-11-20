namespace random_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //产生随机数对象
            //Random 随机数变量名 = new Random();
            Random r = new Random();

            //生成随机数
            int i = r.Next();//生成一个非负数的随机数
            Console.WriteLine(i);

            i = r.Next(100);//生成一个0-99的随机数 不包含右边
            Console.WriteLine(i);

            i =r.Next(5,100);
            Console.WriteLine(i);

            Console.WriteLine("练习题");
            int monsterDef = 10;
            int monsterHp = 20;
            int teacher = 0;
            Random r1 = new Random();
            while(true)
            {
                teacher = r1.Next(8,13);
                if(teacher>monsterDef)
                {
                    monsterHp -= teacher - monsterDef;
                    Console.WriteLine("攻击力为{0}，造成伤害为{1}，怪物剩下{2}血", teacher, teacher - monsterDef, monsterHp);
                    if (monsterHp < 0)
                        break;
                }
                else
                {
                    Console.WriteLine("攻击力为{0}，不足以造成伤害", teacher);
                }
                Console.WriteLine("请按任意键攻击");
                 Console.ReadKey(true);
                Console.Clear();
            }
            Console.WriteLine("怪兽被击败");
        }
    }
}

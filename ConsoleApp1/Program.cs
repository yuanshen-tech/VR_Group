
using System;
using System.Linq.Expressions;

namespace lesson2
{
    #region 知识点一 基本概念
    //被命名的整型常量的集合
    //申明枚举！= 申明枚举变量
    //申明枚举 创建一个自定义枚举类型
    //枚举名 以E或者E_开头
    enum E_自定义枚举名
    {
        自定义枚举项名字,//枚举中包裹的 整型常量 第一项为0 后面一次累计
        自定义枚举项名字1,//可以初始化赋值 下一个会在赋值的基础上累加
    }
    //申明枚举变量 使用申明过的前者 创建一个枚举变量


    #endregion

    #region 知识点二 在哪申明枚举
    //namespace语句块中(常用)
    //class语句块 struct语句块
    //不要在函数语句块中申明

    enum E_MonsterType
    {
        Normal= 0,
        Boss= 1,
    }

    enum E_PlayerType
    {
        Main,
        Other,
    }
    enum E_QQType
    {   //三杠注释 提示玩家含义
        /// <summary>
        /// 在线
        /// </summary>
        Online,
        Offline,
        Busy,
        Invisible,
    }
    enum E_CoffeeType
    {
        Small,
        Middle,
        Big,
    }

    #endregion





    #region 知识点一 基本概念


    #endregion

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("枚举");

            #region 知识点三 枚举的使用
            //申明枚举变量
            //自定义枚举类型 变量名 = 默认值; (自定义的枚举类型。枚举项)
            E_PlayerType playertype = E_PlayerType.Main;
            {
                if (playertype == E_PlayerType.Main) {
                    Console.WriteLine("主玩家逻辑");
                }
                else {
                    Console.WriteLine("其他玩家逻辑");
                }
            }   E_MonsterType monsterType = E_MonsterType.Boss;
            switch (monsterType)
            {
                case E_MonsterType.Normal:
                    Console.WriteLine("普通怪物逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("Boss逻辑");
                    break;
                default:
                    break;
            }

            #endregion

            #region 知识点四 枚举类型转换
            //枚举和int互转
            int i = (int)playertype;
            Console.WriteLine(i);
            //int转枚举
            playertype = 0;

            //枚举转string
            string str = playertype.ToString();
            Console.WriteLine(str);

            //string转枚举
            //Parse后 第一个参数 ：你要转化为的是哪个 枚举类型 第二个参数：用于转换对应枚举用的字符串
            //转换玩还需要用括号强转
            playertype = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Other");
            Console.WriteLine(playertype);
            #endregion

            #region 知识点五 枚举的作用
            // 游戏中总是存在很多个状态
            //综合考虑可能会使用int来表示他的状态
            // 比如 1 行走 2 待机 3 跳跃
            // 枚举可以帮助我们清晰的直到各个状态含义
            #endregion

            #region 练习题
            E_QQType statustype = E_QQType.Online;
            int a = (int)statustype;
            try
            {
                Console.WriteLine("请输入qq状态（0线 1离开 2忙）");
                int qqstatus = Convert.ToInt16(Console.ReadLine());
                E_QQType qqtype = (E_QQType)qqstatus;
                Console.WriteLine(qqtype);
            }
            catch
            {
                Console.WriteLine("请输入正确数字");
            }
        
            try
            {
                Console.WriteLine("请输入想要购买的奶茶（0中杯 1大杯 2超大杯）");
                int cotype = Convert.ToInt16(Console.ReadLine());
                E_CoffeeType coffeeType = (E_CoffeeType)cotype;
                Console.WriteLine(coffeeType);
                switch (coffeeType)
                {
                    case E_CoffeeType.Small:
                        Console.WriteLine("您购买了中杯咖啡，花费了35元");
                        break;
                    case E_CoffeeType.Middle:
                        Console.WriteLine("您购买了大杯咖啡，花费了40元");
                        break;
                    case E_CoffeeType.Big:
                        Console.WriteLine("您购买了超大杯咖啡，花费了43元");
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入正确数字");
            }
      
            

            #endregion
        }
    }
}
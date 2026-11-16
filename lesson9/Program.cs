using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;


namespace array1
{
    #region 结构体 写在namespace里面
    //基本概念
    //是一种自定义变量类型 类似枚举需要自己定义
    //它是数据和函数的集合
    //在结构体中 可以声明各种变量和方法

    //用来表现存在关系的数据集合 比如用结构体表现学生 动物 人类等等

    //基本语法
    //写在namespace
    //关键字 struct

    struct Student //自定义结构体名
    {
        //第一部分
        //变量
        //在结构体里面申明的变量不能初始化
        //变量类型 可以是任意类型 包括结构体 但是不能是自己的结构体
        struct s;
        public int age;
        public int sex;
        public int number;
        public string name;

        //第二部分
        //构造函数(可选)
        #region 构造函数
        //没有返回值
        //函数名必须和结构体名相同
        //必须有参数
        //如果申明了构造函数 那么必须在其中对所有数据初始化

        public Student(int age, int sex, int number, string name)
        {
            //新的关键字 this
            //代表自己
            this.sex = sex;
            this.age = age;
            this.number = number;
            this.name = name;
        }
        #endregion
        //第三部分
        //函数
        //不需要加static关键字

        public void Speek()
        {
            Console.WriteLine("My name is {0},my age is {1}",name,age);
        }

        //注意结构体名字 帕斯卡命名法
    }
    
        
        

    struct s;
    #endregion
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 结构体的使用
            Student s1;
            //
            s1.age = 1;
            s1.sex = 2;
            s1.number = 3;
            s1.name = "111";
            s1.Speek();
            #endregion

            #region 访问修饰符
            //修饰结构体中的变量和方法 是否能被外部使用
            //public 公共的 可以被外部访问
            //private 私有的 只能内部使用
            //默认不写为private
            #endregion


        
        }
    }
}

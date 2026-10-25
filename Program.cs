Console.WriteLine("Hello, World!");
//知识点一 折叠代码
//主要作用是让我们编程时逻辑更加清晰
//他是有#region #endregion配对出现的
//他的具体作用是可以将中间包裹的代码折叠起来避免代码太凌乱
//变量申明的固定写法  变量类型 变量名 = 初始值；
//int i =1
//变量类型有14种变化
//变量名  我们自定义 要按照一定的规则
//初始值 一定要和变量类型统一
//=和；是固定不变的
//变量类型
//一定要死记硬背各种变量类型的名字
//一定要记忆不同变量类型所能存储的范围
//一定要记住各种不同变量类型所能存储的类型
#region 知识点二 变量的类型
//1.有符号的整型变量 是能储存一定范围内正负数以及0的变量
//sbyte -128~~~127
//int -21亿多~~~21亿多
//short -32768~~~32767之间的数
//long -9百万兆~~~9百万兆之间的数
//潜在知识点：通过+来进行拼接打印
//2.无符号的整型变量
//byte 0~~~255
//uint 0~~~42亿多的一个范围
//ushort 0~~~65535之间的一个数
//ulong 0~~~18百万兆之间的一个数
//3.浮点数（小数）
//float能储存7/8位有效数字 根据编译器的不同 有效数字也有可能不一样
//有效数字是从左到右从非0数开始算有效数字的
//之所以要在后面加f是因为在c#中申明的小数默认是doubie的类型加f是告诉系统他是float类型
float f = 0.123456f;
Console.WriteLine(f);
//double 存储15~17位有效数字
double d = 0.12345678901234567890;
Console.WriteLine(d);
//decimal存储27~~~28位的有效数字 不建议使用
//要在后面加上m
decimal de = 0.123456789012345678901234567890m;
Console.WriteLine(de);
//4.特殊的变量
//bool ture false 表示真假的数据类型
bool bo = true;
bool bo2 = false;
Console.WriteLine(bo+"__"+bo2 );
//char是用来储存单个字符的变量类型
char c = 'a';
//stying是字符串类型用来储存多个字符的没有上限
string s = "123456677开得飞快的思考";
Console.WriteLine(s);
//变量的使用和修改 不能无中生有 必须先申明才能用
int x = 100;
Console .WriteLine (x);
x = 99;
Console .WriteLine (x);
#endregion
#region 知识点三 为什么有那么多不同的变量类型
//不同的变量存储的范围和类型不一样 本质上是占用的内存空间不同
//选择不同的数据（变量）类型装在不同的数据里
//数字用int小数用float字符串用string真假用bool
#endregion
#region 知识点四 多个相同类型的变量同时申明
int y = 1;
float f2 = 3.2f;
string s2 = "123";
bool bo3=true;
//多个变量同时申明
//固定写法
//变量类型 变量名 = 初始值，变量名=初始值.....;
int a1 = 1, b1 = 2, c1 = 3, d1 = 4;
Console.WriteLine(b1);
string str1 = "123", str2 = "234";
Console.WriteLine(str1 +str2);
#endregion
#region 知识点五 变量初始化相关
//变量申明时可以不设置初始值 但是不建议这样写 这样不安全
int a3;
a3 = 1;
Console.WriteLine(a3);
#endregion
#region 知识点六 变量的存储空间（内存中）
//1byte=8bit
//1MB=1024byte
//1GB=1024MB
//1TB=1024GB
//通过sizeof的方法可以获取变量类型所占的内存空间（单位：字节）
//有符号
int sbyteSize = sizeof(sbyte);
Console.WriteLine("sbyte所占的字节数为" + sbyteSize);
int intSize = sizeof(int);
Console.WriteLine("int所占的字节数为" + intSize);
int shortSize = sizeof(short);
Console.WriteLine("short所占的字节为" + shortSize);
int longSize = sizeof(long);
Console.WriteLine("long所占的字节为" + longSize);
//无符号的变量和有符号的变量一一对应
//浮点数
int floatSize = sizeof(float );
Console.WriteLine("float所占的字节数为" + floatSize);
int doubleSize = sizeof(double);
Console.WriteLine("double所占的字节数为" + doubleSize);
int decimalSize = sizeof(decimal );
Console.WriteLine("decimal所占的字节为" + decimalSize);
//sizof是不能得到string类型所占的内存的大小
//因为字符串的长度是可变的
//char所占的字节数是1
//bool所占的字节数是1
#endregion
#region 知识点七 变量的本质
//变量的本质是2进制，是一堆0和1
//1byte相当于8个0或者1
//10进制转2进制   用短除法直到最后为1
//2进制转10进制   从右往左看最右边的一位为第0位如果该位不为0则加上2的n次方
#endregion
#region 知识点八 变量的命名规则
//1.不能重名
//2.不能以数字开头
//3.不能用程序关键字命名
//4.不能有特殊符号（下划线除外）
//建议的命名规则 变量名要有意义 用英文或者拼音来表示变量的作用
//非常不建议的命名规则 用汉字命名
#endregion
#region 知识点九 常用的命名规则
//驼峰命名法  首字母小写 之后单词首字母大写
//帕斯卡命名法  所有单词首字母都大写
//潜在知识点 c#中对大小写字母是敏感的 是区分 的
#endregion
#region  知识点十 常量的申明
//关键字 const
//固定写法
//const 变量类型 变量名=初始值；
//常量的特点
//1.必须初始化
//2.不能被修改
//作用：申明一些固定不变的量
#endregion
#region 知识点十一 转义字符的使用
//转义字符是字符串的一部分用来表示一些特定含义的字符
//比如在字符串中表现单引号，引号 空行
//固定写法
//  \字符
//不同的\加字符的组合表示不同的含义
//常用的转义字符
//单引号 \'
string str3 = "\'2632627\'";
Console.WriteLine(str3);
//双引号  \"
//换行 \n
//斜杠   \\   计算机文件路径
//不常用转义字符
//制表符 （空一个tab键） \t
//光标退格  \b
//空字符 \0
//警报音   \a
Console .WriteLine ("\'123444\'1234556\n778879\a879898\t8898\\9898989");
#endregion
#region 知识点十二 隐式转换
//相同大类型之间的转换
int i = 1;
long l = 1;
short sh= 1;
sbyte sb4 = 1;
l = i;//int隐式转换成了long
//可以用大范围装小范围（隐式转换）
//但不能用小范围装大范围
//无符号的同样如此
//浮点数
decimal de1 = 1.1m;
float f5 = 1.1f;
double do5=1.1;
//double这个类型没法用隐式转换的形式去储存double和float
//但是float可以隐式转换为double
do5= f5;
Console.WriteLine(do5);
//特殊类型之间不存在隐式转换
#endregion 
#region  知识点十三 不同大类型的隐式转换
//无符号和有符号之间
//有符号的变量是不能够隐式转换成无符号的
//有符号的变量是可以装无符号的前提是范围一定要是涵盖的
//浮点数是可以装在任何整数的
//整数是不能隐式储存浮点数的
//bool没有办法和其他类型相互隐式转换
//char类型可以隐式转换为整型和浮点型
//char不能隐式存储其他类型的变量
//char隐式转换成的数字其实是一个ASCII码值
//string类型无法和其他类型进行隐式转换
#endregion 











using System.Runtime.CompilerServices;

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
//总结 隐式转换的规则
//高精度（大范围）装低精度（小范围）
//double--float--整数--char
//decimal--整数--char
//string和bool不参与隐式转换

#endregion 
#region 知识点十四 显示转换
//括号强转 一般情况下 将高精度类型强制转换为低精度
//语法 变量类型 变量名=（变量类型）变量
//相同大类的整型
//有符号的整型
int i4 = 1;
sbyte sb3 = 1;
short s4 = 1;
long l4 = 1;
s4 = (short)i4;
Console.WriteLine(s4);
//括号强转 可能会出现范围问题造成的异常
//浮点数强转成整型时会直接抛弃小数点后面的小数
//char和数值类型是可以相互转化的
i4 = (int)1.64f;
Console.WriteLine(i4);
//bool和string不能通过括号去强转
//Parse法  把字符串类型转换为对应的类型
//语法 变量类型。Parse("字符串")
//注意 字符串必须能够转成对应类型否则报错
//有符号
//我们填写字符串 必须是要能够转成对应类型的字符 如果不符合规则 会报错
//值的范围必须是能够被变量存储的值 否则报错
sbyte sb5 = sbyte.Parse("123");
Console.WriteLine(sb5);
//这两句话的意思是一样的
Console.WriteLine(sbyte.Parse("123"));
//无符号
Console.WriteLine(byte.Parse("123"));
 Console.WriteLine(ushort .Parse("123"));
Console.WriteLine(ulong .Parse("123"));
Console.WriteLine(uint.Parse("123"));
//浮点数
float f6=float.Parse ("12.9");
double do6 = double.Parse("123.999999");
//特殊类型
bool bo5 = bool.Parse("true");
Console .WriteLine (bo5);
char c5 = char.Parse("A");
//Convert法
//作用 更准确的将各个类型的变量相互转化
//语法 Convert.To目标类型（变量或常量）
//注意 变量的填写必须正确 否则出错
//转字符串 如果是把字符串转成对应类型 那字符串一定要合法合规
int a7 = Convert.ToInt32("123");
Console.WriteLine(a7);
a7= Convert.ToInt32(1.65437f);//会四舍五入
//能够把bool类型也转换成数值类型
a7 = Convert.ToInt32(true );
Console .WriteLine (a7);
a7= Convert.ToInt32(false );
Console.WriteLine(a7);
//每个类型都存在对应的方法
sbyte sb6 = Convert.ToSByte("123");
short s7 = Convert.ToInt16("123");
int i5 = Convert.ToInt32("123");
long l6 = Convert.ToInt64("123");
//无符号的同样如此
float f7 = Convert.ToSingle("12.3");
double de5 = Convert.ToDouble("12.3");
decimal de6 = Convert.ToDecimal("12.3");
//特殊类型
bool bo8 = Convert.ToBoolean("true");
char c8 = Convert.ToChar("A");
string s8 = Convert.ToString("123");
//其他类型转string
//作用 拼接打印
//语法 变量.toString();
string str6 = 1.ToString();
str6 = true.ToString();
str6 = 'A'.ToString();
str6 = 1.2f.ToString();
//当我们进行字符串拼接时 就会自动调用tostring
#endregion 
#region 知识点十五 异常捕获
//作用
//将玩家输入的内容存储在string类型的变量中
string str7 = Console.ReadLine();
//可以避免当代码报错时 出现程序卡死的情况
//基本语法
//必备部分
try{
                //希望进行异常捕获的代码块
                //放到try中
                //如果try中的代码报错了  不会让程序卡死
}
catch{
    //如果出错了  会执行catch中的代码来捕获异常
}
//可选部分
finally{
    //最后执行的代码  不管有没有出错 都会执行其中的代码
}
//注意 异常捕获代码基本结构中不需要加；在里面写代码时才需要加；
#endregion
#region 知识点十六
//赋值符号
//=
//先看右侧 再看左侧 把右侧的值赋值给左侧
//算数运算符号的优先级
//乘除取余高于加减
//有多层括号时从里往外算
//算数运算符的自增减
//a++先用再加
//++a先加再用
#endregion 
#region 知识点十七  字符串的拼接
//之前的运算符只是用数值类型变量进行数学运算的
//字符串可以通过加号拼接
string str8 = "123";
str8= str8 + "456";
//复合运算符+=
str8 = "123";
str8 += "1" + 4 + true;
Console.WriteLine(str8);
//字符串的拼接方式2
//固定语法
//string.Format("待拼接的内容"，内容1，内容2，.....);
//想要被拼接的内容用占位符代替{数字} 数字：0~~n依次往后
string.Format("我是{0},我今年{1}岁，我想要{2}", "唐老师",18, "天天学习很好向上");
//控制台拼接打印的方法和上述一样
#endregion 
#region 知识点十八  条件运算符
//用于比较两个变量或常量
//是否大于 >
//是否小于 <
//是否等于 ==
//是否不等于 ！=
//是否大于等于>=
//是否小于等于<=
//条件运算符一定存在左右两边的内容
//左边内容 条件运算符 右边内容
//条件运算符不能直接使用
//纯比较不用结果对我们来说毫无意义
//比较的结果返回的是一个bool类型的值
//true和false 如果比较的条件满足 那就返回true 不满足就返回false
int a= 5;
int b= 10;
bool result = a > b;
Console.WriteLine(result);
//计算结果比较
//条件运算符的优先级低于算术运算符
//先计算再比较
//不能进行范围比较
//1<a<6
//不能这样写
//特殊类型char string bool只能同类型进行==和！=比较
//只要是数值就能进行条件运算符的比较
//char类型不仅能和自己类型进行比较还能和数值类型进行比较还能和字符类型进行大小比较
#endregion
#region 知识点十八 逻辑运算符
//逻辑与
//符号 &&
//规则 对两个bool值进行逻辑运算 有假为假 同真为真
//bool类型的值 bool变量 条件运算符
//逻辑运算符的优先级低于条件运算符 算术运算符
//逻辑或
//符号 ||
//规则 对两个bool类型的值进行逻辑运算 有真为真 同假为假
//逻辑非
//符号 ！
//规则 对一个bool类型的值取反 真变假 假变真
//逻辑非优先级较高相对于算术运算符 关系运算符 其他逻辑运算符 赋值运算符
//混合使用的优先级
//！（逻辑非）的优先级最高 &&(逻辑与)的优先级高于逻辑或
//逻辑运算符的优先级低于算数运算符 条件运算符（逻辑或除外）
//逻辑运算符的短路规则
//||有真则真
//只要 逻辑与或者逻辑或左边满足了条件
//右边的内容对我们来说不重要
//逻辑或 有真则真 只要左边为真了右边就不重要
//逻辑与 有假为假 只要左边为假了右边就不重要
#endregion
#region 知识点十九 位运算符
//位运算符主要是用数值类型进行计算的
//将数值转换为2进制 再进行位运算
//位 与 &
//规则 连接两个数值进行计算 将数值转换为2进制
//对位运算有0则0
int aa = 1;//001
int bb = 5;//101
//    001
//&   101
//    001=1
int cc = aa & bb;
Console.WriteLine(cc);
//多个数值进行位运算时 没有括号时 从左到右依次计算
//位或 |
//规则 连接两个数值进行位运算 将数值转为2进制
//对位运算 有1则1
//异或 ^
//规则 连接两个数值进行运算将数值转换为2进制
//对位运算 相同为0 不同为1
//都是两个两个的算
//位取反 ~
//规则 写在数值前面 将数值转换为2进制
//对位运算 0变1 1变0
a = 5;//0101
c = ~a;
//0000 0000 0000 0000 0000 0000 0000 0101
//1111 1111 1111 1111 1111 1111 1111 1010
//反码补码知识
//左移<<和右移>>
//左移几位 右侧加几个0
//右移几位 右侧去掉几个数
#endregion
#region  知识点二十 三目运算符
//基本语法 3个空位 2个符号
//固定语法 空位   ？空位     ：空位；
//关键信息：bool类型？bool类型为真返回内容：bool类型为假返回内容；
//三目运算符 会有返回值 这个返回值类型必须一致，并且必须使用
//string str=true?"条件为真"："条件为假"；
//第一个空位始终是结果为bool类型的表达式  bool变量 条件表达式 逻辑运算符表达式
//第二三个空位什么表达式都可以 只要保证结果类型一致
#endregion
#region 知识点二十一 if语句
//让顺序执行的代码产生分支
//第一个让我们的程序产生逻辑变化的语句
//作用：满足条件时 多执行一些代码
//语法：
//if(bool类型的值)
//{
//    满足条件执行的代码

//}
//注意 
//1.if语句的语法部分不需要写分号
//if语句可以嵌套使用
if(true )
{
    Console.WriteLine("if中输入的代码");
   
}int aaa = 1;
if (aaa>0&&aaa<5)
{
    //Console.WriteLine("aaa在0和5之间");

}
string Name = "李书毅";
string passWard = "666";
if (Name =="李书毅"&&passWard =="666")
{


    Console.WriteLine("用户登录成功");

}
//嵌套使用
if (Name =="李书毅")
{
    Console.WriteLine("用户名验证成功");
    if (passWard =="666")
    {
        Console.WriteLine("密码验证成功");
    }
}

//可以无限嵌套，从上往下依次执行
//if....else语句
//作用：产生两条分支，满足条件做什么，不满足条件做什么
//语法
//if (bool 类型的值)
//{
//满足条件执行的代码

//}
//else
//{
//不满足条件执行的代码
//}
//注意：
//1.if.....else语法部分不用加分号
//2.if.....else语句 可以嵌套
//if....else if....else
//作用 产生n条分支 多条道路选择 最先满足其中的一个条件 就做什么
//语法
//if (bool 类型的值)
//{
//     满足条件执行的代码
//}
//else if (bool类型的值)
//{
//  满足条件执行的代码
//}
//else
//{
//  不满足条件执行的代码
//}
//else是可以省略的
//条件判断从上到下执行 满足了第一个后 之后都不会执行
int a11 = 10;
if (a11>=10)
{
    Console.WriteLine("a大于等于10");
}
else if(a11>5&&a11<10)
{
    Console.WriteLine("a在6到9之间");
}
else if (a11>=0&&a11<=5)
{
    Console.WriteLine("a在0到5之间");
}
else
{
    Console.WriteLine("a小于0");
}
#endregion
#region 知识点二十二 switch语句
//作用 让顺序执行的代码产生分支
//语法
//switch (变量)
//{
//    case 常量:
//     满足条件执行的代码逻辑；   
//        break;
//    case 常量:
//        满足条件执行的代码逻辑
//        break;
//    case 可以有无数个
//    default: 
//        如果上面的case条件都不满足 就会执行default中的代码
//        break;
//}
//注意 常量 只能写一个值 不能去写一个范围 不能写条件运算符 逻辑运算符
//switch 只判断变量是否等于一个固定值
//可定义常量
//贯穿
//作用：满足一定条件时 做的事情是一样的 就可以使用贯穿n句语句
//不写case后面配对的break就叫做贯穿
//满足其中的一个条件 就会执行之后的代码
//case和break之间可以写
int aaaa = 1;
switch (aaaa)
{
    case 1:
    case 2:
        Console.WriteLine("是个数字");
        break;
    default:
        break;
}
#endregion
#region 知识点 二十三 while循环
//作用 
//让顺序执行的代码 可以不停的循环执行某一代码块的内容
//条件分支语句 是让代码产生分支
//循环语句 是 让代码重复执行
//bool类型的变量 条件运算符 逻辑运算符
//while ( bool 类型的值)
//{
//当满足条件时 就会执行while中的内容
//当代码逻辑执行完 会回到while循环开头
//再次进行条件判断
//}
int ii = 0;
//bool类型的值 还可以用逻辑运算符&& ||  ！条件运算符 算符运算符结合运算
while (ii<10)
{
    ++ii;
}
Console.WriteLine(ii);
//嵌套使用
//不仅可以嵌套if switch 还可以嵌套while
int i2 = 0;
while (i2 < 10) ;
{
    ++i2;
    //每次外层循环进来都会创建一个全新的i3  与循环中的i3没有关系
    //如果在内外两层都加上打印 那么 会打印成112345678910...212345678910不断循环直到i2为10
    int i3 = 0;
    {
        ++i3;
    }

}
//流程控制关键词
//break ：跳出循环
//break和if没有关系
//continue：回到循环开始 继续执行
//break和continue主要是和循环配套使用 和if语句无关
//打印1到20之间的奇数
int index = 0;
while (index <=20)
{
    ++index;
    if (index %2==0)
    {
        continue;
    }
    Console.WriteLine(index);
}
//switch出现时 break与它配对
#endregion
#region 知识点二十四 do-while语句
//基本语法
//while语句是先判断条件 再执行
//do-while语句是先斩后奏 先至少执行一次循环中的语句块的逻辑 再判断是否继续
//do
//{
//    //do while循环语句块
//} while (bool 类型的值);
//注意 do while语句存在一个重要的分号
//continue回到while
#endregion  
#region 知识点二十五 for循环
//基本语法
//for (初始表达式;条件表达式;增量表达式)
//{
//    //循环代码逻辑；
//}
//第一个空（初始表达式）：一般申明一个临时变量 用来计数用
//第二个空（条件表达式）：表明进入循环的条件 一个bool类型的结果（bool变量 条件运算符 逻辑运算符 算术运算符）
//第三个空（增量表达式）：用第一个空中的变量 进行自自增减运算 
//第一次进入循环时 才会调用第一个空中的代码
//每次进入循环前 都会判断第二个空的条件 满足才会进入循环逻辑
for (int iii=0;iii<10;iii++ )
{
    Console.WriteLine(iii);
    //执行完循环语句中的逻辑后
    //最后执行第三个空中的代码
    //支持嵌套
    //for循环这三个空都可以空着 根据需求去填写
}
#endregion
 
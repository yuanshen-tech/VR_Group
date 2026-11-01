using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;


namespace array1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region 数组基本概念
            //数组是存储一组相同类型数据的集合
            //数组分为一维 多维 交错数组
            //一般情况 一维数组被简称为数组
            #endregion

            #region 数组的申明
            //变量类型[] 数据名; //但是没有确定房间数
            //变量类型可以是学过的或者没学过的
            int[] arr1;
            //变量类型[] 数组名 = new 变量类型[数组的长度];
            int[] arr2 = new int[5];//初始值每个位置都是0
            //变量类型[] 数组名 = new 变量类型[数组的长度]{内容1,内容2,...}//必须要填够
            int[] arr3 = new int[5] { 1, 2, 4, 5, 7 };
            //变量类型[] 数组名 = new 变量类型[] {}
            //变量类型[] 数组名 = {};
            #endregion

            #region 数组的使用
            int[] array = { 1, 2, 3, 4, 5 };
            //1.数组的长度
            Console.WriteLine(array.Length);
            //2.数组的下标和索引都是从零开始
            //数组和下标可以获得某个元素的值
            //一定不能越界！！！
            Console.WriteLine(array[0]);
            //3.修改数组中的元素
            array[2] = 99;
            Console.WriteLine(array[2]);
            //4.遍历数组
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                sum += array[i];
            }
            Console.WriteLine(sum);

            //5.增加数组的元素
            //数组初始化以后 不能直接添加元素 所有可以搬家 新建一个数组
            int[] array2 = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array = array2;
            array[5] = 78;
            Console.WriteLine("*************************************");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
                sum += array[i];
            }
            Console.WriteLine(sum);

            //6.删除数组的元素
            //同上

            //7.直接查找数组中的元素
            //查找哪一个索引对应的是我们需要的元素
            //只能遍历
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 99) Console.WriteLine(i);
            }
            #endregion

            #region 二维数组
            Console.WriteLine("***********************************");
            //申明
            //变量类型[,] 二维数组名 = new 变量行[行,列]；
            int[,] array1 = new int[3, 3];
            int[,] arra2 = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] array3 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            //1.二维数组的长度
            //获得行和列分别是多长
            //行
            Console.WriteLine(array3.GetLength(0));
            //列
            Console.WriteLine(array3.GetLength(1));
            //2.获取二维数组中的元素
            //!!!第一个索引是0 最后一个是长度-1
            Console.WriteLine(array3[0, 1]);
            //3.修改二维数组元素 得到再赋值
            array3[0, 1] = 99;
            //4.遍历二维数组中的元素 两层循环嵌套
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.WriteLine(array3[i, j]);
                }
            }
            //5.增加数组元素
            Console.WriteLine("**********************************");
            int[,] array4 = new int[3, 3];
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    array4[i, j] = array3[i, j];
                }
            }
            array3 = array4;
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    Console.WriteLine(array3[i, j]);
                }
            }
            #endregion
           
            #region 交错数组
            Console.WriteLine("************************************");
            //申明
            //每一行列都是可以不一样的
            int[][] arr4;
            int[][] arr5 = new int[3][];
            int[][] arr6 = new int[3][] { new int[] { 1, 2, 3 }, new int[] { 1, 2 }, new int[] { 1 } };
            //数组的应用
            int[][] array7 = {new int[] { 1, 2, 3 },new int[] { 4,5} };
            //数组的长度
            Console.WriteLine(array7.GetLength(0));
            Console.WriteLine(array7[1].Length);
            //遍历
            for (int i = 0;i < array7.GetLength(0); i++)
            {
                for(int j = 0;j < array7[i].Length;j++)
                {
                    Console.WriteLine((int)array7[i][j]);
                }
            }
            #endregion


        }
    }
    }
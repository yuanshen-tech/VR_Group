using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;


namespace array1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region
            Console.WriteLine("冒泡排序");
            //排序是计算机内经常进行的一种操作，其目的是将一组“无序”的记录序列调整为“有序”的记录序列
            // 常用的排序例子
            // 871542639
            //把上面的这个无序序列变为有序 （升序或降序）序列的过程
            //123456789 （升序）
            //987654321 （降序）
            // 在程序中 序列一般 存储在数组当中
            // 所以排序往往是对 数组进行排序
            int[] arr = new int[]{8, 7, 1, 5, 4, 2, 6, 3, 9,};
            // 把数组里面的内容变为有序的
            #endregion
            //  7 1 5 4 2 6 3 9
            //  两两相邻 不停比较 不停交换 比较n轮

            #region 冒泡排序基本原理
            //  7 1 5 4 2 6 3 9
            //  两两相邻 不停比较 不停交换 比较n轮

            #endregion 

            #region 代码实现
            //第一步 比较数组中两两相邻的数
            //从头开始
            //第n个数和第n+1个数 比较
            //int t = arr.Length - 1;
            //for (int m = 0; m < arr.Length; m++)
            //{
            //    for (int n = 0; n < t; n++) 
            //    {
            //        //如果第n个数 比第n＋1个数大就交换位置
            //        if (arr[n] > arr[n + 1])
            //        {
            //            int temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //    t--;
            //}
            //for (int i = 0; i < arr.Length;i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //优化
            //确定位置的数字 不用比较了
            //确定一轮后最大值就减小
            for (int m = 0; m < arr.Length; m++)
            {
                for (int n = 0; n < arr.Length -1- m; n++)
                {
                    //如果第n个数 比第n＋1个数大就交换位置
                    if (arr[n] > arr[n + 1])
                    {
                        int temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //优化1.2
            //标志位
            bool isSort = false;
            for (int m = 0; m < arr.Length; m++)
            {
                isSort = false;
                for (int n = 0; n < arr.Length - 1 - m; n++)
                {
                    //如果第n个数 比第n＋1个数大就交换位置
                    if (arr[n] > arr[n + 1])
                    {   isSort = true;
                        int temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }
                }if (!isSort) break;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion

            #region 选择排序
            // 新建中间商
            // 依次比较
            // 找出极值(最大或最小)
            // 放入目标位置
            // 比较n轮

            //代码实现
            //升序
            int[] arr2 = new int[] { 8, 7, 1, 5, 4, 0, 6, 3, 9, };

            //第一轮 申明一个中间商
            //第一轮开始 默认第一个是极值
            int index = 0;
            //第二步 依次比较
            for (int m = 0; m < arr2.Length; m++)
            {
                for (int n = 1; n < arr2.Length-m; n++)
                {
                    if (arr2[index] < arr2[n])
                    {
                        index = n;
                    }
                }
                if (index != arr2.Length - 1 - m)
                {
                    int temp = arr2[index];
                    arr2[index] = arr[arr2.Length - 1 - m];
                    arr2[arr2.Length - 1 - m] = temp;

                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            #endregion



        }
    }
}
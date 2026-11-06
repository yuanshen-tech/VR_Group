using System;
using System.Collections.Generic;

namespace BookBorrowing
{

    // static 意为静态，将这个类，转为静态使用，与非静态的区别在于，无需初始化（new()）

    /// <summary>
    /// 图书馆类
    /// </summary>
    public static class Library
    {

        /// <summary>
        /// 图书馆名称
        /// </summary>
        public static string LibraryName;


        /// <summary>
        /// 该图书馆下的所有图书
        /// </summary>
        public static List<Book> Books = new List<Book>();

        // List<T> T:为泛型 泛型：什么类型都可以

        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="BookName">图书名称</param>
        /// <param name="Price">价格</param>
        /// <param name="IsBorrow">是否被借阅 true：已借阅 false：未借阅</param>
        public static void AddBook(string BookName, double Price, bool IsBorrow)
        {
            Book book1 = new Book();
            book1.IsBorrow = IsBorrow;
            book1.BookName = BookName;
            book1.Price = Price;

            Books.Add(book1);
        }

        /// <summary>
        /// 显示所有的图书
        /// </summary>
        public static void ViewBookList()
        {
            Console.WriteLine($"图书馆名称：{LibraryName}");
            Console.WriteLine("");
            Console.WriteLine("图书名称       价格       是否被借阅");
            foreach (Book book in Books)
            {
                string borrowCN = book.IsBorrow ? "已借阅" : "未借阅";

                //if (book.IsBorrow)
                //{
                //    borrowCN = "已借阅";
                //}
                //else
                //{
                //    borrowCN = "未借阅";
                //}

                Console.WriteLine($"{book.BookName}       {book.Price}       {borrowCN}");
            }
            Console.WriteLine("----------------这是一条分割线------------------------");
        }

    }
}

using System.Collections.Generic;

namespace BookBorrowing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library.LibraryName = "这是一个超级大的图书馆";
            Library.AddBook("C# 从入门到放弃", 5, false);
            Library.ViewBookList();
        }
    }
}

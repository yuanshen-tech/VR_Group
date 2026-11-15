using BookBorrowing1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowing1.DataSource
{
    public class BD
    {

        public static List<Book> list = new List<Book>()
        {

            new Book(1,"c#入门经典", 5, "理工类", 20),
            new Book(2,"红楼梦", 6, "文学类", 12),
            new Book(3,"中国美术史", 3, "艺术类", 8),
            new Book(4,"经济学原理", 2, "经济类", 7),
            new Book(5,"论语", 5, "哲学类", 20),
            new Book(6,"人体解剖学", 10, "医学类", 16),


        };

        public static List<User> Users = new List<User>()
        {
            new User("敏敏",100),
            new User("小明",50),
            new User("红红",60),

        };


     
    }
}

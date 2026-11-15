using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowing1.Entity
{
    public class User
    {
        public User(string _name,double _price)
        {
            this.name = _name;
            this.price = _price;
            this.books = new List<Book>();         
        }

        
        /// <summary>
        /// 借阅人名字
        /// </summary>
        public string name;

        /// <summary>
        ///用户余额 
        /// </summary>
        public double price;

        /// <summary>
        /// 借阅日期
        /// </summary>
        public DateTime? time;
        

        public List<Book> books { get; set; }      //用户借的书



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBorrowing1.Entity
{
    public class Book
    {
        /// <summary>
        /// </summary>
        /// <param name="_bookname"></param>
        /// <param name="_price"></param>
        /// <param name="_classify"></param>
        /// <param name="_stock"></param>
        public Book(int _ID,string _bookname,double _price,string _classify,int _stock,bool _IsLent = false)
        {
            this.ID = _ID;
            this.bookname = _bookname;                                                   //初始化对象的时候把值提前写进去
            this.price = _price;
            this.classify = _classify;
            this.stock = _stock;
            this.IsLent = _IsLent;
        }

        /// <summary>
        /// 书籍序号
        /// </summary>
        public int ID {  get; set; }
        
        /// <summary>
        /// 书籍名字
        /// </summary>
        public string bookname { get; set; }

        /// <summary>
        /// 价格
        /// </summary>
        public double price { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public string classify {  get; set; }

        /// <summary>
        /// 库存数量
        /// </summary>
        public int stock {  get; set; }    

        /// <summary>
        /// 是否出借
        /// </summary>
        public bool IsLent { get; set; }

        /// <summary>
        /// 借阅人姓名
        /// </summary>
        public string Boname {  get; set; }
    }
}

using BookBorrowing1.DataSource;
using BookBorrowing1.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookBorrowing.Demo
{
     class Library:BD
    {
        public void Librarys()
        {
            Console.WriteLine("----------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------欢迎来到图书馆-------------------");
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine("----------------------------------------------");

            Menu();
            SwitchMenu();
            

        }

        private void SwitchMenu()
        {
            Console.WriteLine("请选择功能：");

            Console.ForegroundColor = ConsoleColor.Blue;
            switch(Choice())
            {
                case 1:
                    Showbook();
                    break;
                case 2:
                    Borrow();
                    break;
                case 3:
                    Return();
                    break;
                case 4:
                    PriceChange();
                    break;
                case 5:
                    Delete();
                    break;
                case 6:
                    Charge();
                    break;
                case 7:
                    SearchUser();
                    break;



            }
            
            SwitchMenu();
            Console.ForegroundColor = ConsoleColor.White;
        }

        void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" (1) 查看现有书籍");
            Console.WriteLine(" (2) 借阅书籍");
            Console.WriteLine(" (3) 归还书籍");
            Console.WriteLine(" (4) 价格变更");
            Console.WriteLine(" (5) 删除");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" (6) 充值");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" (7) 查询借阅人信息");
            Console.ForegroundColor = ConsoleColor.White;
        }

        int Choice()
        {
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        void Showbook()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("编号            名字            类型            价格             库存            是否借阅");
            foreach (var b in list)
            {
                Console.WriteLine($"{b.ID}            {b.bookname}           {b.classify}           {b.price}            {b.stock}             {b.IsLent}");
            }
            Console.ForegroundColor= ConsoleColor.White;
        }

        /// <summary>
        /// 借阅：两块逻辑：
        /// 公共逻辑：选择书籍借阅，选择借阅人
        /// 1.图书的逻辑处理
        ///   根据输入的图书编号查询书籍  book.borrow = true  stock-1             
        /// 2.用户的逻辑处理
        ///   根据输入的用户名称，查询用户   借阅日期：DateTime.Now  User.books.Add(book)
        ///   showbook
        /// </summary>
        void Borrow()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请输入需要借阅的图书编号：");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入借阅人的姓名：");
            string UName = Console.ReadLine();

            
            Book book = list.FirstOrDefault(i => i.ID == ID);
            book.IsLent = true;
            book.stock--;
            book.Boname = UName;

            
            User user = Users.FirstOrDefault(i => i.name == UName);
            user.time = DateTime.Now;
            user.books.Add(book);
            user.price -= book.price;
            Showbook();



        }
        
        /// <summary>
        /// 1.图书逻辑：选择图书编号进行归还
        /// 2.
        /// </summary>
        void Return()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请输入归还的图书编号：");
            int ID = int.Parse(Console.ReadLine());

            Console.WriteLine("请输入您的姓名：");
            string UName = Console.ReadLine();

            
            Book book = list.FirstOrDefault(i => i.ID == ID);
            book.stock++;
            //book.Boname = UName;


            User user = Users.FirstOrDefault(i => i.name == UName);
            user.books.RemoveAll(b => b.ID == ID);


            Showbook();
            
        }

        
        /// <summary>
        /// 价格变更：选书籍，输入新的价格，根据输入的编号找到这本书，book.价格（赋值）
        /// </summary>
        void PriceChange()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请选择要变更的书籍：");
            int ID = int.Parse(Console.ReadLine());

            Book book = list.FirstOrDefault(i => i.ID == ID);
            Console.WriteLine("请输入新的价格：");
            book.price = double.Parse(Console.ReadLine());
            Showbook();
        }


       
        void Delete()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("请选择要删除的图书编号：");
            int ID = int.Parse(Console.ReadLine());

            Book book = list.FirstOrDefault(i => i.ID == ID); //找到书的编号
            int index = list.Count();
            list.Remove(book);
            int index2 = list.Count();
            if(index < index2)
            {
                Console.WriteLine("删除成功");
                
            }
            Showbook();




        }

        void SearchUser()
        {
            Console.WriteLine("请输入用户姓名：");
            string name = Console.ReadLine();  //获取一个控制台输入的文本 
            User user = Users.FirstOrDefault(i => i.name == name);

            if (user != null)
            {
                Console.WriteLine("查询成功！");
                Console.WriteLine($"用户名字：{user.name}");
                Console.WriteLine($"用户余额：{user.price}");
                Console.WriteLine("该用户借阅的所有图书");
                foreach (var b in user.books)
                {
                    string person = b.IsLent ? "暂无借阅人":"已被借阅";
                    Console.WriteLine($"编号：{b.ID},名字：{b.bookname},价格：{b.price},分类：{b.classify},库存数量：{b.stock},借阅人姓名：{b.Boname}");
                }

            }
            else
            {
                Console.WriteLine("没有该用户！");
            }


            

        }

        void Charge()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("--------------图书借阅卡--充值平台----------------");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("--------------尊敬的VIP用户，欢迎您---------------");
            Console.WriteLine("------------------------------------------------");
            Console.ForegroundColor= ConsoleColor.White;

            Console.WriteLine("请输入用户姓名");
            string name = Console.ReadLine();
            User user = Users.FirstOrDefault(i => i.name == name);

            Console.WriteLine("请输入充值金额");
            double Price = Convert.ToDouble(Console.ReadLine());

            
            if(user != null)
            {
                double sum = user.price;
                user.price += Price;
                Console.WriteLine("充值成功！");
                Console.WriteLine($"用户姓名:{user.name}");
                Console.WriteLine($"用户余额：{user.price}");
            }
            else if (user == null)
            {
                Console.WriteLine("没有该用户！");
            }



        }
    }
}

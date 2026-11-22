using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game
{
    public class Bag
    {
        public Bag(string _Uname,string _Rarity,int _Count,double _Price)
        {
            this.Uname = _Uname;
            this.Rarity = _Rarity;
            this.Count = _Count;
            this.Price = _Price;
            
        }
        /// <summary>
        /// 物品名称
        /// </summary>
        public string Uname { get; set; }

        /// <summary>
        /// 物品稀有度
        /// </summary>
        public string Rarity { get; set; }

        /// <summary>
        /// 物品数量
        /// </summary>
        public int Count {  get; set; }

        /// <summary>
        /// 物品售价
        /// </summary>
        public double Price {  get; set; }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game
{
    public class AuctionHouse
    {
        public AuctionHouse(string _Iname,int _AuctionPrice)
        {
            this.Iname = _Iname;
            this.AuctionPrice = _AuctionPrice;
        }

        /// <summary>
        /// 魂兽名字
        /// </summary>
        public string Iname {  get; set; }
      
        /// <summary>
        /// 拍卖价格
        /// </summary>
        public int AuctionPrice {  get; set; }

        


        
    }
}

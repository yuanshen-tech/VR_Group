using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game.Enity
{
    public class Player
    {

        public Player(int _ID,string _name,int _level,int _Balance)       
        {
            this.ID = _ID;
            this.name = _name;
            this.level = _level;
            this.Balance = _Balance;
            this.Things = new List<Bag>();
            this.skills = new List<Skill>();
        }


        /// <summary>
        /// 玩家编号
        /// </summary>
        public int ID {  get; set; }

        /// <summary>
        /// 玩家昵称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 玩家等级
        /// </summary>
        public int level { get; set; }

        /// <summary>
        /// 玩家背包中的所有物品
        /// </summary>
        public List<Bag> Things { get; set; }

        /// <summary>
        /// 金魂币数量
        /// </summary>
        public int Balance { get; set; }

        /// <summary>
        /// 玩家所有的技能
        /// </summary>
        public List<Skill> skills { get; set; }


    }
}

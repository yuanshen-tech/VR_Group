using Soul_Land_mobile_game.Soul;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game.Enity
{
    public class NpcTask
    {
        public NpcTask(int _id, string _Cname,string _commission,string _Award)
        {
            this.id = _id;
            this.Cname = _Cname;
            this.Commission =  _commission;
            this.Award = _Award;
        }

        /// <summary>
        /// 委托编号
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// NPC名字
        /// </summary>
        public string Cname {  get; set; }
       
        /// <summary>
        /// 委托内容
        /// </summary>
        public string Commission {  get; set; }

        /// <summary>
        /// 委托奖励
        /// </summary>
        public string Award {  get; set; }
    }
}

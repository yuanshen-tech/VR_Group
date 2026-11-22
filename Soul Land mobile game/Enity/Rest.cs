using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game.Enity
{
    public class Rest
    {
        public Rest(int _Id,string _type) 
        {
            this.Id = _Id;
            this.type = _type;
        }

        /// <summary>
        /// 方式编号
        /// </summary>
        public int Id {  get; set; }

        /// <summary>
        /// 放松方式（内容）
        /// </summary>
        public string type { get; set; }


    }
}

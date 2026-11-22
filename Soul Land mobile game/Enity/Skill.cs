using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game.Enity
{
    public class Skill
    {
        public Skill(int _iD,int _SP,string _Describe)
        {
            this.iD = _iD;
            this.SP = _SP;
            this.Describe = _Describe;  
        }

        /// <summary>
        /// 技能顺序
        /// </summary>
        public int iD {  get; set; }

        /// <summary>
        /// 技能点
        /// </summary>
        public int SP {  get; set; }

        /// <summary>
        /// 技能描述
        /// </summary>
        public string Describe {  get; set; }
    }
}

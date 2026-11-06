using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Test;

namespace Test.Name
{
    public class Role
    {
        public static List<Character> Roles = new List<Character>()
        {
            new Character("温迪",Country.Mondstadt.ToString(),element.Anemo.ToString()),
            new Character("砂糖",Country.Mondstadt.ToString(),element.Anemo.ToString()),
            new Character("杜林",Country.Mondstadt.ToString(),element.Pyro.ToString()),
            new Character("可莉",Country.Mondstadt.ToString(),element.Pyro.ToString()),
            new Character("兹白",Country.LiYue.ToString(),element.Geo.ToString()),
            new Character("少女",Country.NodKrai.ToString(),element.Hydro.ToString()),
            new Character("莉奈娅",Country.NodKrai.ToString(),element.Geo.ToString()),
            new Character("叶落亚",Country.NodKrai.ToString(), element.Hydro.ToString()),
            new Character("桑多涅",Country.Snezhnaya.ToString(),element.Cryo.ToString()),
            new Character("奥黛塔",Country.Snezhnaya.ToString(),element.Cryo.ToString()),
            new Character("米提亚",Country.Snezhnaya.ToString(), element.Electro.ToString()),
            new Character("阿罗夏",Country.Snezhnaya.ToString(),element.Electro.ToString()),
        };
    }

    public enum Country
    {

        /// <summary>
        /// 蒙德
        /// </summary>
        Mondstadt = 1,
        /// <summary>
        /// 璃月
        /// </summary>
        LiYue = 2,
        /// <summary>
        /// 挪德卡莱
        /// </summary>
        NodKrai = 3,
        /// <summary>
        /// 至冬
        /// </summary>
        Snezhnaya = 4,
    }

    public enum element
    {
        /// <summary>
        /// 风
        /// </summary>
        Anemo = 1,
        /// <summary>
        /// 火
        /// </summary>
        Pyro = 2,
        /// <summary>
        /// 岩
        /// </summary>
        Geo = 3,
        /// <summary>
        /// 水
        /// </summary>
        Hydro = 4,
        /// <summary>
        /// 冰
        /// </summary>
        Cryo = 5,
        /// <summary>
        /// 雷
        /// </summary>
        Electro = 6,


    }
}

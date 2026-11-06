using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    /// <summary>
    /// 角色
    /// </summary>
    public class Character
    {

        /// </summary>
        /// <param name="_role"></param>
        /// <param name="_element"></param>
        /// <param name="_country"></param>
        public Character(string _role, string _Country, string _element)
        {
            this.Role = _role;
            this.element = _element;
            this.country = _Country;
        }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string Role;

        /// <summary>
        /// 角色元素
        /// </summary>
        public string element;

        /// <summary>
        /// 角色所属国家
        /// </summary>
        public string country;


    }
}

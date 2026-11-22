using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game.Enity
{
    public class SoulBeast
    {

        public SoulBeast(string _Name , string _Cultivation, string _Type, string _Attribute,string _DropMaterial) 
        {
            this.Name = _Name;
            this.Cultivation = _Cultivation;
            this.Type = _Type;
            this.Attribute = _Attribute;
            this.Attribute = _Attribute;
            this.DropMaterial = _DropMaterial;
        }




        /// <summary>
        /// 魂兽名字
        /// </summary>
        public string Name {  get; set; }

        /// <summary>
        /// 魂兽的修为年限
        /// </summary>
        public string Cultivation {  get; set; }

        /// <summary>
        /// 魂兽类型
        /// </summary>
        public string Type {  get; set; }

        /// <summary>
        /// 魂兽属性
        /// </summary>
        public string Attribute {  get; set; }

        /// <summary>
        /// 魂兽掉落材料
        /// </summary>
        public string DropMaterial {  get; set; }
    }
}

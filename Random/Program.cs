using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test.Name;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Role role = new Role();

            Random random = new Random();

            List<Character> store = new List<Character>();


            while (store.Count < 4)
            {
                int i = random.Next(0, Role.Roles.Count);
                Character character = Role.Roles[i];

                // 用随机到的 角色名称 去和已经随机到的匹配，没有的插入集合
                if (!store.Any(c => c.Role == character.Role))
                {
                    store.Add(character);

                }

            }

            StringBuilder sbRole = new StringBuilder();
            StringBuilder sbFramework = new StringBuilder();
            List<string> frameworkList = new List<string>();

            // 队伍为魔导，月结晶，星超导叠加

            // 输出 store
            foreach (Character s in store)
            {
                sbRole.Append(s.Role);
                sbRole.Append(",");

                if (s.country == Country.Mondstadt.ToString() && s.element == element.Anemo.ToString() || s.element == element.Pyro.ToString())
                {
                    frameworkList.Add("魔导");
                    //sbFramework.Append($"该四人队伍为魔导体系");
                }
                else if (s.country == Country.LiYue.ToString() && s.element == element.Geo.ToString()
                    || s.country == Country.NodKrai.ToString() && s.element == element.Hydro.ToString() || s.element == element.Geo.ToString())
                {
                    frameworkList.Add("月结晶");
                    //sbFramework.Append($"该四人队伍为月结晶体系");
                }
                else if (s.country == Country.Snezhnaya.ToString() && s.element == element.Cryo.ToString()
                          || s.element == element.Electro.ToString())
                {
                    frameworkList.Add("星超导");
                    //sbFramework.Append($"该四人队伍为星超导体系");
                }
            }

            frameworkList = frameworkList.Distinct().ToList();

            // 代码改动了，用于测试提交代码
            string frameStr = string.Join("、", frameworkList);
            
            sbFramework.Append($"队伍为：{frameStr}");

            Console.WriteLine(sbRole.ToString());
            Console.WriteLine(sbFramework.ToString());

            /*
             如果角色属于蒙德，则为魔导体系  如果角色属于璃月和挪德卡菜，且元素包含岩和水，则为月结晶体系  如果角色属于至冬，且元素包含冰和雷，则为星超导体系
             
             */

        }
    }
}

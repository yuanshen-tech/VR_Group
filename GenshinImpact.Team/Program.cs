using GenshinImpact.Team.DataSource;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinImpact.Team
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 配队集合
            List<string> roleNames = new List<string>();

            bool isContinue = true;

            Console.WriteLine("是否随机选择一个角色？Y ：是，F：关闭程序");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                while (isContinue)
                {
                    // 配队只能四个角色
                    if (roleNames.Count() >= 4)
                    {
                        Console.WriteLine("配队选择结束！");
                        isContinue = false;
                        break;
                    }

                    Random rand = new Random();
                    int randNumber = rand.Next(0, DBHelper.LoadTotalCount());

                    string roleName = DBHelper.LoadAllRoleName().ElementAt(randNumber);
                    Console.WriteLine("随机到的角色为：{0}，是否添加到配队中？Y ：是，F：换一个", roleName);
                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        if (roleNames.Any(c => c == roleName))
                        {
                            Console.WriteLine($"{roleName} 已存在队伍中，不允许重复添加！");
                            continue;
                        }
                        roleNames.Add(roleName);
                        Console.WriteLine($"添加成功！当前配队中的角色为：{string.Join(",", roleNames)}");
                        Console.WriteLine("开启下一轮随机");
                    }
                }

                List<string> roleFrameworks = roleNames.Select(DBHelper.LoadRoleFrameworkByName).ToList();

                string roleNameJoin = string.Join(",", roleNames);
                string roleFrameworkJoin = string.Join(",", roleFrameworks);

                Console.WriteLine($"{roleNameJoin}({roleFrameworkJoin})");
            }

        }
    }
}

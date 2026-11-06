using GenshinImpact.Team.Entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinImpact.Team.DataSource
{
    public class DBHelper : DB
    {

        /// <summary>
        /// 返回所有的角色名称
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> LoadAllRoleName()
        {
            return Roles.Select(c => c.RoleName);
        }

        /// <summary>
        /// 返回所有的角色数量
        /// </summary>
        /// <returns></returns>
        public static int LoadTotalCount()
        {
            return Roles.Count();
        }

        /// <summary>
        /// 根据角色名称获取详情
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string LoadRoleInfoByName(string name)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (!Roles.Exists(c => c.RoleName == name))
            {
                throw new Exception($"未找到该角色：{name}");
            }

            Role role = Roles.FirstOrDefault(c => c.RoleName == name);

            stringBuilder.Append($"角色名称：{role.RoleName}");
            stringBuilder.Append($"国家：{role.RoleCountry}");
            stringBuilder.Append($"体系：{role.RoleFramework}");
            stringBuilder.Append($"反应：{role.RoleReaction}");

            return stringBuilder.ToString();

        }

        /// <summary>
        /// 根据角色名称获取体系
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static string LoadRoleFrameworkByName(string name)
        {
            StringBuilder stringBuilder = new StringBuilder();

            if (!Roles.Exists(c => c.RoleName == name))
            {
                throw new Exception($"未找到该角色：{name}");
            }

            Role role = Roles.FirstOrDefault(c => c.RoleName == name);
            return role.RoleFramework.ToString();

        }

    }
}

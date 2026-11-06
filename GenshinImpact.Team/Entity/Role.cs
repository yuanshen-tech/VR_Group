using GenshinImpact.Team.Enum;

namespace GenshinImpact.Team.Entity
{

    /// <summary>
    ///  角色类
    /// </summary>
    public class Role
    {

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="roleCountry"></param>
        /// <param name="roleFramework"></param>
        /// <param name="roleReaction"></param>
        public Role(string roleName, Country roleCountry, Framework roleFramework, Reaction roleReaction)
        {
            this.RoleName = roleName;
            this.RoleCountry = roleCountry;
            this.RoleFramework = roleFramework;
            this.RoleReaction = roleReaction;
        }

        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        public Country RoleCountry { get; set; }

        /// <summary>
        /// 体系
        /// </summary>
        public Framework RoleFramework { get; set; }

        /// <summary>
        /// 反应体系
        /// </summary>
        public Reaction RoleReaction { get; set; }

    }
}

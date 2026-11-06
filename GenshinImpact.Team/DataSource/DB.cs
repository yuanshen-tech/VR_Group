using GenshinImpact.Team.Entity;
using GenshinImpact.Team.Enum;

using System.Collections.Generic;

namespace GenshinImpact.Team.DataSource
{
    public class DB
    {
        public static List<Role> Roles = new List<Role>()
        {
            new Role("兹白", Country.璃月, Framework.月反应体系, Reaction.月结晶),
            new Role("莉奈娅", Country.挪德卡莱, Framework.月反应体系, Reaction.月结晶),
            new Role("哥伦比亚", Country.挪德卡莱, Framework.月反应体系, Reaction.月反应通用辅助),
            new Role("玛薇卡", Country.纳塔, Framework.夜魂体系, Reaction.融化),
            new Role("那位莱特", Country.枫丹, Framework.荒芒体系, Reaction.纯色直伤),
            new Role("桑多涅", Country.至冬, Framework.星反应体系, Reaction.星超导),
            new Role("奥黛塔", Country.至冬, Framework.星反应体系, Reaction.星反应通用辅助),
            new Role("菲林斯", Country.挪德卡莱, Framework.月反应体系, Reaction.月感电),
            new Role("奈芙尔", Country.挪德卡莱, Framework.月反应体系, Reaction.月绽放),
            new Role("温迪", Country.蒙德, Framework.魔导体系, Reaction.扩散),
            new Role("斯柯克", Country.未知, Framework.直伤体系, Reaction.冻结),
            new Role("芙宁娜", Country.枫丹, Framework.荒芒体系, Reaction.增伤),
            new Role("枫原万叶", Country.稻妻, Framework.增幅体系, Reaction.增伤),
            new Role("希诺宁", Country.纳塔, Framework.夜魂体系, Reaction.减抗),

        };
    }
}

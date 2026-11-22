using Soul_Land_mobile_game.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game.Soul
{
    public class SB
    {
        public static List<SoulBeast> list = new List<SoulBeast>
        {
            new SoulBeast("银爪鬼虎","四万年","敏攻系","暗/速度","魂兽精血"),
            new SoulBeast("狂暴雷猿","三万六千年","强攻系","雷/力量","兽魂晶"),
            new SoulBeast("岩甲地龙","二万四千年","防御系","土/护盾","魂兽内丹"),
            new SoulBeast("寒晶冰鹭","三万两千年","控制系","冰","玄铁匕首"),
            new SoulBeast("深渊魔蛛","五万年","强攻系","暗/毒","魂兽精血"),
            new SoulBeast("流光灵鹿","四万八千年","辅助系","光/生命","兽魂晶"),
            new SoulBeast("风翎隼","三万九千年","敏攻系","风","魂兽精血"),
            new SoulBeast("万纹古藤","三万五千年","植物系","生命","魂兽内丹"),

        };

        public static List<Player> players = new List<Player>
        {
            new Player(1,"烬",50,100),
            new Player(2,"栖魂",60,200),
            new Player(3,"苍珩",70,50),
        };

        public static List<Bag> Things = new List<Bag>()
        {
            new Bag("魂兽内丹","七等",15,30),
            new Bag("兽魂晶","五等",2,45),
            new Bag("二十四桥明月夜","三等",1,2000),
            new Bag("玄铁匕首","六等",6,50),
            new Bag("魂兽精血","四等",0,100),
            new Bag("森林信物","五等",4,150),
            new Bag("绮罗郁金香","二等",2,5000),
            new Bag("望穿秋水露","二等",1,5000),
            new Bag("相思断肠红","一等",1,100000),
            new Bag("诸葛神弩","五等",8,450),
            new Bag("孔雀翎","一等",2,2000000),
            new Bag("佛怒唐莲","特等",0,500000000000),

        };



        public static List<AuctionHouse> auctions = new List<AuctionHouse>()
        {
            new AuctionHouse("吞马",50),
            new AuctionHouse("九彩神鹿",60),
            new AuctionHouse("仙月兔",80),
            new AuctionHouse("月华灵龟",100),

        };


        public static List<NpcTask> npcTasks = new List<NpcTask>()
        {
            new NpcTask(1,"药老","落日森林深处生长着紫芝，我需要三株紫芝炼制凝神丹，切记不要惊扰附近栖息的魂兽","金魂币、凝神丹、少量修为经验"),
            new NpcTask(2,"守林老者","捕获了一只受惊的银月鹿，它天性温和，并无伤人之心，请你将它带到月华溪谷放生","生灵祝福BUFF、声望、灵韵碎片"),
            new NpcTask(3,"唐门锻器学徒","我打造暗器缺少蜂尾针的原料，需要收集十份铁线草的纤维，森林外围就可以找到","基础暗器·蜂尾针、锻造材料"),
            new NpcTask(4,"行商","我要带着药草前往索托城，路途之上有凶魂兽游荡，麻烦你一路护送我平安抵达","金魂币、随机百年魂环碎片"),
            new NpcTask(5,"村长","一头狂暴的风狼在村落附近游荡，时常袭击路人，麻烦你前去将它解决，保护村民","魂币、兽骨材料"),

        };



        public static List<Rest> rests = new List<Rest>()
        {
            new Rest(1,"冥想修炼"),
            new Rest(2,"钓鱼"),
            new Rest(3,"酒馆修整"),
            new Rest(4,"锻造暗器"),
            new Rest(5,"和NPC闲谈"),

        };



        public static List<Skill> skills = new List<Skill>()
        {
            new Skill(1,40,"魂力"),
            new Skill(2,40,"精神力"),
            new Skill(3,40,"体力"),
            new Skill(4,40,"生命亲和度"),
            new Skill(5,40,"悟性"),
            new Skill(6,40,"道心"),
            new Skill(7,40,"暗器精通"),
            new Skill(8,40,"恢复力"),
        };
    }
}

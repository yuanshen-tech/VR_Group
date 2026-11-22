using Soul_Land_mobile_game.Enity;
using Soul_Land_mobile_game.Soul;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Soul_Land_mobile_game
{
    public class MockTask:SB
    {
        public void start()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("-----------欢迎来到斗罗大陆-------------");
            Console.WriteLine("--------------------------------------");
            

            Menu();
            SwitchMenu();
            Console.ForegroundColor = ConsoleColor.White;

        }


        private void SwitchMenu()
        {
            Console.WriteLine("请选择任务菜单");
            switch (Console.ReadLine())
            {
                case "1":
                    DefeatSoulBeast();
                    break;
                case "2":
                    ReleaseSoulBeast();
                    break;
                case "3":
                    AcceptQuest();
                    break;
                case "4":
                    GatherMaterials();
                    break;
                case "5":
                    Rest();
                    break;
                case "6":
                    TriggerPlot();
                    break;
                case "7":
                    OpenBackpack();
                    break;
                case "8":
                    ViewSkill();
                    break;
            }
        }


            void Menu()
            {
             Console.ForegroundColor= ConsoleColor.White;
             Console.WriteLine("--------------------------------------");
             Console.WriteLine("-----------支线任务：进入星斗大森林-----");
             Console.WriteLine("-----------1.选择魂兽击败---------------");
             Console.WriteLine("-----------2.去拍卖场中买一只魂兽放生----");
             Console.WriteLine("-----------3.接取NPC委托---------------");
             Console.WriteLine("-----------4.收集材料------------------");
             Console.WriteLine("-----------5.休息：选择放松方式---------");
             Console.WriteLine("-----------6.触发与唐三的结识剧情-------");
             Console.WriteLine("-----------7.查看背包------------------");
             Console.WriteLine("-----------8.查看技能------------------");
             Console.WriteLine("-----------离开星斗大森林---------------");
             Console.WriteLine("--------------------------------------");
             Console.ForegroundColor = ConsoleColor.White; 
            }

        void DefeatSoulBeast()
        {
            Random randomsoulBeast = new Random();
            int index = randomsoulBeast.Next(0, list.Count());
            SoulBeast soulBeast = list[index];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{soulBeast.Cultivation}的{soulBeast.Name}向你袭来!");
            Console.ForegroundColor = ConsoleColor.White ;

            Console.WriteLine("请输入玩家编号:");
            int ID = int.Parse(Console.ReadLine());
            Player player = players.FirstOrDefault(i => i.ID == ID);

            Random random = new Random();
            int ram = random.Next(0, 90);
            if (player.level >= 60 )
            {
                Console.WriteLine("恭喜玩家，成功击败！");
                
                Console.WriteLine($"获得魂兽材料：{soulBeast.DropMaterial}+1");
                Bag bag = Things.FirstOrDefault( c => c.Uname == soulBeast.DropMaterial);
                player.Things.Add(bag);
                bag.Count++;
                
            }
            else
            {
                Console.WriteLine("未击败魂兽");
            }

            
            SwitchMenu();
        }

        void ReleaseSoulBeast()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("-------------欢迎来到拍卖场-----------------");
            Console.WriteLine("------------------------------------------");
            Console.ForegroundColor= ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("请先查看您的基本信息");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("玩家编号        玩家昵称         玩家金魂币余额（万）");
            foreach (var p in players)
            {
                Console.WriteLine($"{p.ID}                   {p.name}                     {p.Balance}  ");
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("接下来开始拍卖珍稀魂兽");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("魂兽名字         拍卖价格(万)");
            
            foreach (var a in auctions)
            {
                Console.WriteLine($"{a.Iname}              {a.AuctionPrice}");
            }
            

            Console.WriteLine("请输入玩家编号:");
            int ID = int.Parse(Console.ReadLine());
            Player player = players.FirstOrDefault(i => i.ID == ID);

            if (player.Balance >= 80) 
            {
                Console.WriteLine("恭喜玩家成功拍下魂兽，并放归森林！");

                Random randomskill = new Random();
                int index2 = randomskill.Next(0, skills.Count());
                Skill skill = skills[index2];

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"奖励：{skill.Describe}+5");
                Console.ForegroundColor = ConsoleColor.White;
                Skill skill1 = skills.FirstOrDefault(y => y.Describe == skill.Describe);
                player.skills.Add(skill);
                skill.SP +=5;
                
               
            }
            else
            {
                Console.WriteLine("拍卖失败！");
            }

            SwitchMenu();


        }

        void AcceptQuest()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("请查看委托");
            Console.ForegroundColor = ConsoleColor.White ;
            Console.WriteLine("委托编号     NPC                  委托内容                                                                                奖励");
            foreach (var n in npcTasks)
            {
                Console.WriteLine($"{n.id}           {n.Cname}            {n.Commission}            {n.Award}");
            }

            Console.WriteLine("请选择委托：");
            int id = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("成功接取委托！请玩家尽快完成");
            Console.ForegroundColor= ConsoleColor.White ;

            SwitchMenu();
        }

        void GatherMaterials()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("已进入材料区");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("请输入玩家编号:");
            int ID = int.Parse(Console.ReadLine());
            Player player = players.FirstOrDefault(i => i.ID == ID);

            Random randomthing = new Random();
            int index = randomthing.Next(0, Things.Count());
            Bag bag = Things[index];

           
            Console.WriteLine($"玩家获得：{bag.Uname}+1");
            player.Things.Add( bag );
            bag.Count++;




            SwitchMenu();
        }

        void Rest()
        {
            Console.WriteLine($"休息选择         内容");
            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var r in rests)
            {
                Console.WriteLine($"{r.Id}              {r.type}");
            }
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("请选择休息方式：");
            int Id = int.Parse(Console.ReadLine());
            Rest rest = rests.FirstOrDefault(i => i.Id == Id);

            Console.WriteLine("请输入玩家编号:");
            int ID = int.Parse(Console.ReadLine());
            Player player = players.FirstOrDefault(i => i.ID == ID);


            Random randomskill = new Random();
            int index2 = randomskill.Next(0, skills.Count());
            Skill skill = skills[index2];

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"休息完毕，奖励：{skill.Describe}+3");
            Console.ForegroundColor = ConsoleColor.White;
            Skill skill1 = skills.FirstOrDefault(y => y.Describe == skill.Describe);
            player.skills.Add(skill);
            skill.SP += 3;

            

            SwitchMenu();
        }

        void TriggerPlot()
        {
            Console.WriteLine("特殊事件：遇到唐三");
            Console.WriteLine("玩家可选择是否上前触发剧情：Y:是  F:关闭程序");

            if(Console.ReadLine().ToUpper() == "Y")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("场景：你在森林安全区域打坐休息，草木微动，一名身着朴素蓝衣的少年缓步走来，" +
                                        "掌心一缕淡蓝的蓝银草轻轻收回，神色沉静温和");
                Console.ForegroundColor =ConsoleColor.White;
                Thread.Sleep(3000);
                Console.WriteLine("唐三：这里是魂兽出没的区域，独自在此打坐，要多加小心");
                Thread.Sleep(3000);
                Console.WriteLine("你：多谢提醒，我在此休整魂力。你是？");
                Thread.Sleep(3000);
                Console.WriteLine("唐三：我叫唐三。方才感知到附近有魂力波动，便过来看看。看你的气息，也是一名魂师");
                Thread.Sleep(3000);
                Console.WriteLine("你：我是来这里历练、收集材料的");
                Thread.Sleep(3000);
                Console.WriteLine("唐三：历练是好事，但切莫滥杀无辜魂兽。魂兽与我们本就共存于这片大陆，若非必要，不必取其性命。" +
                                        "（目光柔和，顿了顿）我看你似乎对魂兽习性不甚熟悉，若是遇到难以应对的危险，或许我可以帮你一把。");
                Thread.Sleep(3000);
                Console.WriteLine("你：我记下了。你也是来这里修炼的吗？");
                Thread.Sleep(3000);
                Console.WriteLine("唐三：嗯。我习惯在安静的地方打磨武魂，感悟魂力。对了，这个给你。" +
                                      "（伸手递来一小株带着淡香的药草）凝神草，打坐时使用，可以更快恢复精神力，算是一点见面礼。");


                Thread.Sleep(3000);
                Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine("叮！");
                Console.WriteLine("解锁支线：唐三的托付，获得道具：凝神草");
                Console.ForegroundColor = ConsoleColor.White;

                SwitchMenu();
            }




            SwitchMenu();
        }

        void OpenBackpack()
        {
            Console.WriteLine("请输入玩家编号:");
            int ID = int.Parse(Console.ReadLine());
            Player player = players.FirstOrDefault(i => i.ID == ID);

            //if (!(bool)(player?.Things.Any()))
            //{
            //    Console.WriteLine($"玩家：{player.name},背包是空的...");
            //    SwitchMenu();
            //    return;
            //}

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("物品                   稀有度(一~七等)              数量(个)              售价（金魂币）");
            Console.ForegroundColor = ConsoleColor.White;
            foreach(var T in player.Things)
            {
                Console.WriteLine($"{T.Uname}                     {T.Rarity}                     {T.Count}                    {T.Price}");
            }

            SwitchMenu();

        }


        void ViewSkill()
        {
            Console.WriteLine("请输入玩家编号:");
            int ID = int.Parse(Console.ReadLine());
            Player player = players.FirstOrDefault(i => i.ID == ID);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("技能序号            技能点              技能描述");
            Console.ForegroundColor = ConsoleColor.White ;
            foreach (var s in skills)
            {
                Console.WriteLine($"{s.iD}                     {s.SP}                 {s.Describe}");
            }


            SwitchMenu();
        }
    }
}

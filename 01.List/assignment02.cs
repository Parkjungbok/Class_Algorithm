using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01.List
{
    internal class assignment02
    {
        //A++) 인벤토리 구현(아이템 얻기, 아이템 버리기)
        class Item                                  //아이템기능
        {
            protected string name;
            int price;

            public virtual void Buy()
            {
                Console.WriteLine("을/를 삽니다");

            }
            public virtual void Sell()
            {
                Console.WriteLine("을/를 팝니다");
            }
        }
        class Longsword : Item                      //아이템구현
        {
            public override void Buy()
            {
                Console.Write("롱소드");
                base.Buy();
            }
            public override void Sell()
            {
                Console.Write("롱소드");
                base.Sell();
            }
        }

        class Player
        {
            private List<Item> inventory = new List<Item>();
            public void BuyItem(Item itme)
            {
                itme.Buy();
                inventory.Add(itme);
            }
            public void SellItem(Item itme)
            {
                itme.Sell();
                inventory.Remove(itme);
            }
            public void Inven()
            {
                for (int i = 0; i < inventory.Count; i++)
                {
                    Console.Write($"{inventory[i]}");
                }
            }
        }
        public static void Main()
        {
            Longsword longsword = new Longsword(); // 롱소드 객체 생성
            Player player = new Player();
            List<string> Inventory = new List<string>();


            player.BuyItem(longsword);
            player.BuyItem(longsword);
            player.SellItem(longsword);
            player.BuyItem(longsword);
            player.Inven();
        }
    }
}
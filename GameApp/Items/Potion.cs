using GameApp.Libraries.Abstract;

namespace GameApp.Items
{
    public class Potion : GameItem
    {
        public Potion() : base("Potion",90) { }
        public Potion(int Defense) : base("Potion",90,Defense){}
        public override void UseItem()//override or to copy the behavior/s of the parent class which is the GameItem(in Abstract)
        {
            Console.WriteLine("You drank: " + this.Name + " /Restored: " + this.HealAmount);
         }
    }
    }

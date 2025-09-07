using GameApp.Libraries.Abstract;

namespace GameApp.Items
{
    public class Shield : GameItem
    {
        public Shield() : base("Shield",40) { }
        public Shield(int Defense) : base("Shield",40,Defense){}
        public override void UseItem()
        {
            Console.WriteLine("Item Equipped: " + this.Name + " /Defense increased by: " + this.Defense);
         }
    }
    }

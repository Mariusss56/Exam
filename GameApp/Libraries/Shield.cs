using GameApp.Libraries.Interfaces;

namespace GameApp.Libraries
{
    public class Shield : IGameItem
    {
        private readonly String Name = "Shield";
        private int Defense;
        private int currDefense;

        public Shield()
        {
            this.Defense = 100;
            this.currDefense = Defense;

        }
        public Shield(int Def)
        {
            this.Defense = 40;
            this.currDefense = Def;
        }
        public void UseItem() 
        {
            if (this.currDefense == 0)
            {
                Console.WriteLine("No more Defense");
            }
             else
            {
                this.currDefense--;
                Console.WriteLine("Used: "+ this.Name+" Remaining: "+this.currDefense);
    
}
        }
        public void ShowInfo()
        {
            Console.WriteLine("Heal: " + this.Defense + "Remaining Defense" + this.currDefense);
        }
    }
}
using GameApp.Libraries.Interfaces;

namespace GameApp.Libraries
{
    public class Potion : IGameItem
    {
        private readonly String Name = "Potion";
        private int HealAmount;
        private int currHealAmount;

        public Potion()
        {
            this.HealAmount = 40;
            this.currHealAmount = HealAmount;

        }
        public Potion(int Heal)
        {
            this.HealAmount = 40;
            this.currHealAmount = Heal;
        }
        public void UseItem()
        {
            if (this.currHealAmount == 0)
            {
                Console.WriteLine("No more Heal");
            }
            else
            {
                this.currHealAmount--;
                Console.WriteLine("Used: "+ this.Name+" Remaining: "+this.currHealAmount);
    
}
        }
        public void ShowInfo()
        {
            Console.WriteLine("Heal: " +this.Name+" Heal Amount: " +this.HealAmount + "Remaining Heal" + this.currHealAmount);
        }
    }
}

using GameApp.Libraries.Interfaces;

namespace GameApp.Libraries.Abstract
{
    public abstract class GameItem : IGameItem
    {
    public string Name { get; private set; }  //Auto implements the getter and setter methods
    public int HealAmount { get; private set; } //unaccessible because it is private
    public int  Defense{ get; private set; }  // if public, {get; set;} only without priavte
        //https://www.youtube.com/watch?v=EbW-1fPhXQE
     
        public GameItem(string Name)
        {
            this.Name = Name;
            // Console.WriteLine("Item: " + this.Name);
        }
        public GameItem(string Name, int HealAmount)
        {
            this.Name = Name;
            this.HealAmount = HealAmount;      
            // Console.WriteLine("Item: " + this.Name);
        }
        public GameItem(string Name, int HealAmount, int Defense)
        {
            this.Name = Name;
            this.HealAmount = HealAmount;
            this.Defense = Defense;
          
            // Console.WriteLine("Item: " + this.Name);
        }

        public void ShowInfo()//shows the result "Item: " and and the item
        {

            Console.WriteLine("Item: " + this.Name);
            
        }

        public abstract void UseItem();
    }
}

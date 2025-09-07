
using GameApp.Items;

using GameApp.Libraries.Interfaces;
namespace GameApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            
            Shield shield = new Shield(40);
            shield.ShowInfo();
            shield.UseItem();

            Potion potion = new Potion(90);
            potion.ShowInfo();
            potion.UseItem();


        }
    }
}
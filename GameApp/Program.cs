using GameApp.Libraries.Interface;

namespace GameApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shield shield = new Shield("Iron Shield", 200);

            shield.ShowInfo();
            shield.UseItem();

            Potion potion = new Potion("Health Pot", 60);       

            potion.ShowInfo();
            potion.UseItem();
            
        }

    }
}
using GameApp.Libraries.Interface;

namespace GameApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Shield shield = new Shield("Iron Shield", 100);

            shield.ShowInfo();
            shield.UseItem();
        }

    }
}
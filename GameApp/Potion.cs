using GameApp.Libraries.Abstract;

namespace GameApp.Libraries.Interface
{

    public class Potion : GameItem
    {
        private int HealAmount;

        public Potion (String name, int HealAmount) : base(name)
        {
            this.HealAmount = HealAmount;
        }
        public override void UseItem()
        {
            Console.WriteLine("You drank " + this.Name + ". Restored " + this.HealAmount + "HP!");
        }
    }
}
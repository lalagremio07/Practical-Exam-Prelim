using GameApp.Libraries.Abstract;

namespace GameApp.Libraries.Interface
{

    public class Shield : GameItem
    {
        private int Defense;

        public Shield(String name, int Defense) : base(name)
        {
            this.Defense = Defense;
        }
        public override void UseItem()
        {
            Console.WriteLine("You equipped " + this.Name + ". Defense increased by " + this.Defense);
        }
    }
}
using GameApp.Libraries.Interface;

namespace GameApp.Libraries.Abstract
{
    public abstract class GameItem
    {
        public string Name;

        public GameItem(String Itemname)
        {
            this.Name = Itemname;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Item " + this.Name);
        }
        public abstract void UseItem();
    }
}
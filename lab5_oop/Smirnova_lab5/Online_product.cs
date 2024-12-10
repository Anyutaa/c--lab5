using System;

namespace ShopApp
{
    [Serializable]
    public class OnlineProduct : Product
    {
        public string Link { get; set; }

        public override void Input()
        {
            base.Input();
            Console.Write("Введите ссылку на продукт: ");
            Link = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($"Ссылка на продукт: {Link}");
        }
    }
}

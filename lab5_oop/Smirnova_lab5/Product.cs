using System;
using System.Xml.Serialization;

namespace ShopApp
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }

        public virtual void Input()
        {
            Console.Write("Введите название продукта: ");
            Name = Console.ReadLine();

            Console.Write("Введите цену продукта: ");
            Price = Utils.GetCorrectDouble(1.0, 21000.0);

            Console.Write("Введите дату изготовления продукта (гггг-мм-дд): ");
            ManufactureDate = Utils.GetCorrectDate();

            Console.Write("Введите срок годности (гггг-мм-дд): ");
            ExpiryDate = Utils.GetCorrectDateAfter(ManufactureDate);

            Console.Write("Введите количество продукта: ");
            Quantity = Utils.GetCorrectInt(1, 1000);
        }

        public virtual void Output()
        {
            Console.WriteLine($"\nНазвание продукта: {Name}");
            Console.WriteLine($"Цена продукта: {Price}");
            Console.WriteLine($"Дата изготовления: {ManufactureDate:yyyy-MM-dd}");
            Console.WriteLine($"Годен до: {ExpiryDate:yyyy-MM-dd}");
            Console.WriteLine($"Количество: {Quantity}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ShopApp
{
    public class Shop
    {
        private List<Product> products = new List<Product>();

        public void AddProduct()
        {
            Product product = new Product();
            product.Input();
            products.Add(product);
        }

        public void AddOnlineProduct()
        {
            OnlineProduct onlineProduct = new OnlineProduct();
            onlineProduct.Input();
            products.Add(onlineProduct);
        }

        public void DisplayProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("У вас нет продуктов.");
            }
            else
            {
                foreach (var product in products)
                {
                    product.Output();
                }
            }
        }

        public void ClearProducts()
        {
            products.Clear();
            Console.WriteLine("Список продуктов очищен.");
        }

        public void SaveToFile()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Нет данных для сохранения.");
                return;
            }

            Console.Write("Введите название файла: ");
            string fileName = Console.ReadLine() + ".xml";

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new[] { typeof(OnlineProduct) });
            StreamWriter writer = new StreamWriter(fileName);
            
                serializer.Serialize(writer, products);
            
            Console.WriteLine("Данные успешно сохранены.");
        }

        public void LoadFromFile()
        {
            Console.Write("Введите название файла: ");
            string fileName = Console.ReadLine() + ".xml";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Файл не найден.");
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>), new[] { typeof(OnlineProduct) });
            StreamReader reader = new StreamReader(fileName);
            
                products = (List<Product>)serializer.Deserialize(reader);
            
            Console.WriteLine("Данные успешно загружены.");
        }
    }
}

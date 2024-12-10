using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Shop shop = new Shop();

            while (true)
            {
                Console.WriteLine("\nВыберите вариант из меню:");
                Console.WriteLine("1. Добавить продукт");
                Console.WriteLine("2. Добавить онлайн продукт");
                Console.WriteLine("3. Посмотреть все продукты");
                Console.WriteLine("4. Удалить все продукты");
                Console.WriteLine("5. Записать в файл");
                Console.WriteLine("6. Прочитать из файла");
                Console.WriteLine("0. Выход");
                Console.Write("Выберите действие: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            shop.AddProduct();
                            break;
                        case 2:
                            shop.AddOnlineProduct();
                            break;
                        case 3:
                            shop.DisplayProducts();
                            break;
                        case 4:
                            shop.ClearProducts();
                            break;
                        case 5:
                            shop.SaveToFile();
                            break;
                        case 6:
                            shop.LoadFromFile();
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Неверный ввод. Попробуйте еще раз.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Введите корректный номер действия.");
                }
            }
        }
    }
}

using System;

namespace ShopApp
{
    public static class Utils
    {
        public static int GetCorrectInt(int min, int max)
        {
            int value;
            while (!int.TryParse(Console.ReadLine(), out value) || value < min || value > max)
            {
                Console.WriteLine($"Введите целое число в диапазоне от {min} до {max}.");
            }
            return value;
        }

        public static double GetCorrectDouble(double min, double max)
        {
            double value;
            while (!double.TryParse(Console.ReadLine(), out value) || value < min || value > max)
            {
                Console.WriteLine($"Введите число в диапазоне от {min} до {max}.");
            }
            return value;
        }

        public static DateTime GetCorrectDate()
        {
            DateTime date;
            while (!DateTime.TryParse(Console.ReadLine(), out date))
            {
                Console.WriteLine("Введите корректную дату в формате гггг-мм-дд.");
            }
            return date;
        }

        public static DateTime GetCorrectDateAfter(DateTime startDate)
        {
            DateTime date;
            while (true)
            {
                date = GetCorrectDate();
                if (date > startDate)
                    break;
                Console.WriteLine("Дата должна быть позже начальной.");
            }
            return date;
        }
    }
}

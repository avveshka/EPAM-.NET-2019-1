using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            double number = 28434.3432;
            bool trueInput = false;
            while (!trueInput)
            {
                Console.WriteLine("Выберите культуру : ");
                Console.WriteLine("1: ru vs en");
                Console.WriteLine("2: en vs invariant");
                Console.WriteLine("3: ru vs invariant");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        trueInput = true;
                        Console.WriteLine($"Дата {now.ToString("d", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {now.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))}");
                        Console.WriteLine($"Число {number.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {number.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))}");
                        break;
                    case "2":
                        trueInput = true;
                        Console.WriteLine($"Дата {now.ToString("d", CultureInfo.CreateSpecificCulture("en-US"))} vs {now.ToString("d", DateTimeFormatInfo.InvariantInfo)}");
                        Console.WriteLine($"Число {number.ToString("F", CultureInfo.CreateSpecificCulture("en-US"))} vs {number.ToString("e4", CultureInfo.InvariantCulture)}");
                        break;
                    case "3":
                        trueInput = true;
                        Console.WriteLine($"Дата {now.ToString("d", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {now.ToString("d", DateTimeFormatInfo.InvariantInfo)}");
                        Console.WriteLine($"Число {number.ToString("F", CultureInfo.CreateSpecificCulture("ru-RU"))} vs {number.ToString("e4", CultureInfo.InvariantCulture)}");
                        break;
                    default:
                        Console.WriteLine("Вы выбрали несуществующий вариант!Попробуйте ещё раз.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}

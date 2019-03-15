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
                        OutCulture("ru-RU", "en-US");
                        break;
                    case "2":
                        trueInput = true;
                        OutCulture("en-US", "invariant");
                        break;
                    case "3":
                        trueInput = true;
                        OutCulture("ru-RU", "invariant");
                        break;
                    default:
                        Console.WriteLine("Вы выбрали несуществующий вариант!Попробуйте ещё раз.");
                        break;
                }
            }
            Console.ReadKey();
        }
        public static void OutCulture(string firstCulture, string secondCulture)
        {
            DateTime now = DateTime.Now;
            double number = 28434.3432;
            string dateOut = "d";
            string numberOut = "F";
            string numberOutInvariant = "e4";
            if (secondCulture != "invariant")
            {
                Console.WriteLine($"Число {firstCulture} {number.ToString(numberOut, CultureInfo.CreateSpecificCulture(firstCulture))} vs Число {secondCulture} {number.ToString(numberOutInvariant, CultureInfo.CreateSpecificCulture(secondCulture))}");
                Console.WriteLine($"Дата {firstCulture} {now.ToString(dateOut, CultureInfo.CreateSpecificCulture(firstCulture))} vs Дата {secondCulture} {now.ToString(dateOut, CultureInfo.CreateSpecificCulture(secondCulture))}");
            }
            else
            {
                Console.WriteLine($"Число {firstCulture} {number.ToString(numberOut, CultureInfo.CreateSpecificCulture(firstCulture))} vs Число {secondCulture} {now.ToString(dateOut, DateTimeFormatInfo.InvariantInfo)}");
                Console.WriteLine($"Дата {firstCulture} {now.ToString(dateOut, CultureInfo.CreateSpecificCulture(firstCulture))} vs Дата {secondCulture} {number.ToString(numberOutInvariant, CultureInfo.InvariantCulture)}");
            }
        }
    }
}

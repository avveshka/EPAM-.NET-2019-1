using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Dasha = new Person("Даша");
            Person Sasha = new Person("Саша");
            Person Pasha = new Person("Паша");
            Person Kirill = new Person("Кирилл");
            Person Nastya = new Person("Настя");
            Person Ilia = new Person("Илья");
            Office rsreu = new Office(new List<Person> { Dasha, Sasha, Pasha, Kirill, Nastya});
            Dasha.GoToWork();
            Sasha.GoToWork();
            Pasha.GoToWork();
            Kirill.GoToWork();
            Nastya.GoToWork();
            rsreu.Add(Ilia);
            Ilia.GoToWork();
            Ilia.GoHome();
            Nastya.GoHome();
            rsreu.Remove(Kirill);
            Kirill.GoHome();
            Pasha.GoHome();
            Sasha.GoHome();
            Dasha.GoHome();
            Console.ReadKey();
        }
    }
}

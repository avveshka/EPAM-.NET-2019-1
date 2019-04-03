using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public delegate void GreetAll(Person otherPerson, DateTime time);
    public delegate void PartingAll(Person otherName);
    public class Office
    {
        private GreetAll greetAll;
        private PartingAll byeAll;

        public Office(List<Person> persons)
        {
            foreach (var p in persons)
            {  
                p.OnCame += OnCameHandler;
                p.OnLeave += OnLeaveHandler;
            }
        }

        private void OnCameHandler(Person person, DateTime time)
        {

            Console.WriteLine($"[Работник {person.Name} пришел на работу]");
            greetAll?.Invoke(person, time);
            greetAll += person.Greet;
            byeAll += person.Parting;
        }

        private void OnLeaveHandler(Person person)
        {
            Console.WriteLine($"[Работник {person.Name} ушел]");
            greetAll -= person.Greet;
            byeAll -= person.Parting;
            byeAll?.Invoke(person);
        }

        public void Add(Person person)
        {
            Console.WriteLine($"[Работник {person.Name} устроился на работу]");
            person.OnCame += OnCameHandler;
            person.OnLeave += OnLeaveHandler;
        }

        public void Remove(Person person)
        {
            Console.WriteLine($"[Работник {person.Name} уволился с работы]");
            greetAll -= person.Greet;
            byeAll -= person.Parting;
            person.OnCame -= OnCameHandler;
            person.OnLeave -= OnLeaveHandler;
        }
    }
}

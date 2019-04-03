using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public delegate void OnCame(Person person, DateTime time);
    public delegate void OnLeave(Person person);
    public class Person
    {
        private string _name;
        public event OnCame OnCame;
        public event OnLeave OnLeave;

        public Person(string name)
        {
            Name = name;
        }

        public string Name { get => _name; set => _name = value; }

        public void Greet(Person person, DateTime time)
        {
            if (time.Hour < 12)
            {
                Console.WriteLine($"Работник {this.Name} говорит: \" доброе утро, {person.Name} \"");
            }
            else
            {
                if (time.Hour > 16)
                {
                    Console.WriteLine($"Работник {this.Name} говорит: \" добрый вечер, {person.Name} \"");
                }
                else
                {
                    Console.WriteLine($"Работник {this.Name} говорит: \" добрый день, {person.Name} \"");
                }
            }
        }

        public void Parting(Person person)
        {
            Console.WriteLine($"Работник {this.Name} говорит: \" досвидания, {person.Name} \"");
        }

        public void GoToWork()
        {
            OnCame?.Invoke(this, DateTime.Now);
        }

        public void GoHome()
        {
            OnLeave?.Invoke(this);
        }

    }
}

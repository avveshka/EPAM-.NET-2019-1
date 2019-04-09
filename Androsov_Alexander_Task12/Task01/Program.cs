using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            string textToFile = "";
            var stream = @"E:\progs\epam\reposit\EPAM-.NET-2019-1\Androsov_Alexander_Task12\Task01\disposable_task_file.txt";
            string[] arrayNumbers = File.ReadAllLines(stream);
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                int.TryParse(arrayNumbers[i], out var number);
                numbers.Add(number);
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] *= numbers[i];
            }
            for (int i = 0; i < numbers.Count; i++)
            {
                textToFile += numbers[i];
                textToFile += "\r\n";
            }
            File.WriteAllText(stream, textToFile);
        }
    }
}

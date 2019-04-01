using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            String text = "if the type of an expression is a reference type,"
                + " then the class of the referenced object, or even whether"
                + " the value is a reference to an object rather than null,"
                + " is not necessarily known at compile time. There are a"
                + " few places in the Java programming language where the " 
                + "actual class of a referenced object affects program "
                + "execution in a manner that cannot be deduced from the "
                + "type of the expression.";
            text.ToLower();
            Regex words = new Regex("[a-z]+");
            Dictionary<string, int> allWords = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
            MatchCollection wordsInStock = words.Matches(text);
            foreach (Match match in wordsInStock)
            {
                string match1 = match.ToString();
                if(allWords.ContainsKey(match1))
                {
                    allWords[match1]++;
                }
                else
                {
                    allWords.Add(match1,1);
                }
            }
            ICollection<string> outKeys = allWords.Keys;
            foreach (string keyOut in outKeys)
                Console.WriteLine($"Word -> {keyOut}    Times -> {allWords[keyOut]}");
            Console.ReadKey();
        }
    }
}

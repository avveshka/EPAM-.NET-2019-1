using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMyString
{
    public class MyString
    {
        private char[] arrayOfChar;

        public MyString() { }

        public MyString(string s)
        {
            arrayOfChar = s.ToCharArray();
        }

        public static MyString operator +(MyString string1, MyString string2)
        {
            MyString mystring = new MyString();
            mystring.arrayOfChar = new char[string1.arrayOfChar.Length + string2.arrayOfChar.Length];
            string1.arrayOfChar.CopyTo(mystring.arrayOfChar, 0);
            string2.arrayOfChar.CopyTo(mystring.arrayOfChar, string1.arrayOfChar.Length);
            return mystring;
        }

        public static MyString operator -(MyString string1, MyString string2)
        {
            StringBuilder stringbuilder1 = new StringBuilder();
            foreach (char letter in string1.arrayOfChar)
            {
                stringbuilder1.Append(letter);
            }
            string string3 = string2.ToString();
            stringbuilder1.Replace(string3, "");
            return new MyString(stringbuilder1.ToString());
        }

        public static bool operator !=(MyString string1, MyString string2) { return !(string1==string2); ; }

        public static bool operator ==(MyString string1, MyString string2)
        {
            bool equal = true;
            if (string1.arrayOfChar.Length != string2.arrayOfChar.Length)
            {
                return false;
            }

            for (int i = 0; i < string1.arrayOfChar.Length; i++)
            {
                if (string1.arrayOfChar[i] != string2.arrayOfChar[i])
                {
                    return false;
                }
            }

            return equal;
        }

        public override string ToString()
        {
            StringBuilder outputstring = new StringBuilder();
            foreach (char letter in arrayOfChar)
            {
                outputstring.Append(letter);
            }
            return outputstring.ToString();
        }
    }
}

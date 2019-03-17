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
        public StringBuilder Output
        {
            get
            {
                StringBuilder outputstring = new StringBuilder();
                foreach (char letter in arrayOfChar)
                {
                    outputstring.Append(letter);
                }
                return outputstring;
            }
        }
        public static MyString operator +(MyString string1, MyString string2)
        {
            MyString mystring = new MyString();
            mystring.arrayOfChar = new char[string1.arrayOfChar.Length + string2.arrayOfChar.Length];
            for (int i = 0; i < string1.arrayOfChar.Length; i++)
            {
                mystring.arrayOfChar[i] = string1.arrayOfChar[i];
            }
            for (int i = 0; i < string2.arrayOfChar.Length; i++)
            {
                mystring.arrayOfChar[i + string1.arrayOfChar.Length] = string2.arrayOfChar[i];
            }
            return mystring;
        }
        public static MyString operator -(MyString string1, MyString string2)
        {
            StringBuilder stringbuilder1 = new StringBuilder();
            foreach (char letter in string1.arrayOfChar)
            {
                stringbuilder1.Append(letter);
            }
            string string3 = "";
            foreach (char letter in string2.arrayOfChar)
            {
                string3 += letter;
            }
            stringbuilder1.Replace(string3, "");
            return new MyString(stringbuilder1.ToString());
        }
        public static bool operator !=(MyString string1, MyString string2) { return true; }
        public static bool operator ==(MyString string1, MyString string2)
        {
            bool equal = true;
            if (string1.arrayOfChar.Length != string2.arrayOfChar.Length)
            {
                equal = false;
                return equal;
            }
            for (int i = 0; i < string1.arrayOfChar.Length; i++)
            {
                if (string1.arrayOfChar[i] != string2.arrayOfChar[i])
                {
                    equal = false;
                }
            }
            return equal;
        }
    }
}

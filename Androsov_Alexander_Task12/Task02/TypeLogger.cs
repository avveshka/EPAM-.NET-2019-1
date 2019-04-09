using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class TypeLogger
    {
        private string _type;
        public TypeLogger(string type)
        {
            Type = type;
        }

        public string Type
        {
            get
            {
                return _type;
            }
            private set
            {
                if(value == "console" || value == "logfile")
                {
                    _type = value;
                }
            }
        }

        public void Log(string str)
        {
            if(Type == "console")
            {
                Console.WriteLine(str);
            }
            File.AppendAllText(Git.logDirectory, str);
        }

    }
}

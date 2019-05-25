using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Award 
    {
        private static int countAwards = 0;
        private string _title;
        private string _description;

        public Award()
        {
              
        }

        public Award(string title)
        {
            countAwards++;
            ID = countAwards;
            Title = title;
        }

        public Award(string title, string description)
        {
            countAwards++;
            ID = countAwards;
            Title = title;
            Description = description;
        }

        public Award(int id,string title)
        {
            countAwards++;
            ID = id;
            Title = title;
        }

        public Award(int id,string title, string description)
        {
            countAwards++;
            ID = id;
            Title = title;
            Description = description;
        }

        public int ID { get; set; }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException("слишком длинне название");
                }
                _title = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value.Length > 250)
                {
                    throw new ArgumentException("слишком длинне описание");
                }
                _description = value;
            }  
        }
    }
}

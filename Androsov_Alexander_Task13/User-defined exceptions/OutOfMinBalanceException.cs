using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exceptions
{
    public class OutOfMinBalanceException : Exception
    {
        public OutOfMinBalanceException() { }

        public OutOfMinBalanceException(string message) : base(message) { }

        public OutOfMinBalanceException(string message, Exception inner) : base(message, inner) { }
    }

}

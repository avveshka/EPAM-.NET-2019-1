using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exceptions
{
    public class OutOfMaxDepositAmountException : Exception
    {
        public OutOfMaxDepositAmountException() { }

        public OutOfMaxDepositAmountException(string message) : base(message) { }

        public OutOfMaxDepositAmountException(string message, Exception inner) : base(message, inner) { }
    }
}

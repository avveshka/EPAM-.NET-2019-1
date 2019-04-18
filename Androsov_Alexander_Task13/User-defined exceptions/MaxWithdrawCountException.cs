using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exceptions
{
    public class MaxWithdrawCountExceptionException : Exception
    {
        public MaxWithdrawCountExceptionException() { }

        public MaxWithdrawCountExceptionException(string message) : base(message) { }

        public MaxWithdrawCountExceptionException(string message, Exception inner) : base(message, inner) { }

    }
}

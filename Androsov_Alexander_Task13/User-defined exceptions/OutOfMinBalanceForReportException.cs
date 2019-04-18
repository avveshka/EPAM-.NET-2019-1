using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_defined_exceptions
{
    public class OutOfMinBalanceForReportException : Exception
    {
        public OutOfMinBalanceForReportException() { }

        public OutOfMinBalanceForReportException(string message) : base(message) { }

        public OutOfMinBalanceForReportException(string message, Exception inner) : base(message, inner) { }
    }
}

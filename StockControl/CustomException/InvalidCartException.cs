using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControl.CustomException
{
   public class InvalidCartException : Exception
    {
        public InvalidCartException()
        {
        }

        public InvalidCartException(string message) : base("Invalid cart value: " + message)
        {
        }

        public InvalidCartException(string message, Exception inner) : base("Invalid cart value: " + message, inner)
        {
        }
    }
}

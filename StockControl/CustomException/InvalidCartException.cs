using System;

namespace StockControl.CustomException
{
   public class InvalidCartException : Exception
    {
        public InvalidCartException(string message) : base("Invalid cart request value: " + message)
        {
        }
    }
}

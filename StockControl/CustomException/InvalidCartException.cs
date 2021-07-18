using System;

namespace StockControl.CustomException
{
   public class InvalidCartException : Exception
    {
        public InvalidCartException(string message) : base("Invalid cart value: " + message)
        {
        }
    }
}

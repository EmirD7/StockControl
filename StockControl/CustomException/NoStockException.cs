using System;

namespace StockControl.CustomException
{
    public class NoStockException : Exception
    {
        public NoStockException(int itemId) : base("No stock for given item id: " + itemId)
        {
        }
    }
}

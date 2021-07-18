using System;

namespace StockControl.CustomException
{
    public class NoStockException : Exception
    {
        public NoStockException(int itemId) : base("No stock left for given item id: " + itemId)
        {
        }
    }
}

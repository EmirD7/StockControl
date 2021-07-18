using System;

namespace StockControl.CustomException
{
    public class NoStockException : Exception
    {
        public NoStockException(int itemId, int remaining) : base("Insufficient stock left for item id: " + itemId + " available left: " + remaining)
        {
        }
    }
}
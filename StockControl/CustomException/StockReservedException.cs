using System;

namespace StockControl.CustomException
{
    public class StockReservedException : Exception
    {
        public StockReservedException(int itemId, int remaining) : base("Insufficient unreserved items left for item id: " + itemId + " available left: " + remaining)
        {
        }
    }
}

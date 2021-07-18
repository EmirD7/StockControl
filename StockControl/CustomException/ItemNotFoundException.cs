using System;

namespace StockControl.CustomException
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException(int itemId) : base("Item not found for given id" + itemId)
        {
        }
    }
}

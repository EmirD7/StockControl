using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockControl.CustomException
{
    public class ItemNotFoundException : Exception
    {
        public ItemNotFoundException()
        {
        }

        public ItemNotFoundException(int itemId) : base("Item not found for given id" + itemId)
        {
        }

        public ItemNotFoundException(int itemId, Exception inner) : base("Item not found for given id" + itemId, inner)
        {
        }
    }
}

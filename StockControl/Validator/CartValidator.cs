using StockControl.CustomException;
using StockControl.Model;

namespace StockControl.Validator
{
    public class CartValidator
    {
        private CartValidator()
        {

        }
        public static void Validate(Cart cart)
        {
            if (cart.Quantity < 0)
                throw new InvalidCartException("Quantity can't be negative!");
            if (cart.Quantity == 0)
                throw new InvalidCartException("Quantity can't be zero!");
            if (cart.UserId <= 0)
                throw new InvalidCartException("Invalid user id!");
            if (cart.ItemId <= 0)
                throw new InvalidCartException("Invalid item id!");
        }
    }
}

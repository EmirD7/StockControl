using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockControl.Model;
using StockControl.Service;
using StockControl.Validator;
using System;

namespace StockControl.Controller
{
    [Route("Cart")]
    [ApiController]
    public class CartController : ControllerBase
    {
        ICartService cartService;
        
        public CartController(ICartService cartService) {
            this.cartService = cartService;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]       
        public IActionResult AddCart(Cart cart)
        {
            try
            {
                CartValidator.Validate(cart);
                cartService.AddCart(cart);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
            return Ok("Item has successfully added to the cart.");
        }
    }
}

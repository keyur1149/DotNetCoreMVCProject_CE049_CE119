using Microsoft.AspNetCore.Mvc;
using OnlineGift.Data.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGift.Data.ViewComponent
{
    public class ShoppingCartSummary
    {
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        /*
        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            // return View(items.Count);
            return View();
        }
        */
        
    }
}

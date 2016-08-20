using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Eshopy.Models;

namespace Eshopy.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FNUC.Models
{
    public class ShoppingBasket
    {
        public int ShoppingBasketId { get; set; }
        public virtual List<ShoppingProduct> ShppingProdutcs { get; set; }
        public int UserId { get; set; } 
    }
}
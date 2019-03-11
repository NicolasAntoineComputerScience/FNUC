using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FNUC.Models
{
    public class ShoppingBasket
    {
        [Key]
        public int ShoppingBasketId { get; set; }
        public virtual List<ShoppingProduct> ShoppingProdutcs { get; set; }
        public int UserId { get; set; } 

    }
}
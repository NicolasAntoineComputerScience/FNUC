using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FNUC.Models
{
    public class ShoppingProduct
    {
        public int ShoppingProductId { get; set; }
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public int PricePerUnity { get; set; }
    }
}
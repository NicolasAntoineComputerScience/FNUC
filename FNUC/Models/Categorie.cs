using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FNUC.Models
{
    public class Categorie
    {
        [Key]
        public int CategorieId { get; set; }
        [Display(Name = "Nom")]
        public string Nom { get; set; }

        [Display(Name = "Liste des sous categories")]
        public virtual List<Categorie> subCategories { get; set; }
    }
}
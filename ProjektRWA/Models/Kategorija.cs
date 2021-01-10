using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjektRWA.Models
{
    public class Kategorija
    {
        [ScaffoldColumn(false)]
        public int KategorijaID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string KategorijaIme { get; set; }

        [Display(Name = "Product Description")]
        public string Description { get; set; }

        public virtual ICollection<Artikal> Artikli { get; set; }
    }
}
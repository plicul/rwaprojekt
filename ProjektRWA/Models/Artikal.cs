using System;
using System.ComponentModel.DataAnnotations;
namespace ProjektRWA.Models
{
    public class Artikal
    {
        [ScaffoldColumn(false)]
        public int ArtikalID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string ArtikalIme { get; set; }

        [Required, StringLength(10000), Display(Name = "Product Description"), DataType(DataType.MultilineText)]
        public string Opis { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")] 
        public double? ArtikalCijena { get; set; }

        public int? KategorijaID { get; set; }

        public virtual Kategorija Kategorija { get; set; }
    }
}
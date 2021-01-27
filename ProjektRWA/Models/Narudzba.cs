using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ProjektRWA.Models
{
    public class Narudzba
    {   
        [Key]
        public int OrderId { get; set; }

        public System.DateTime OrderDate { get; set; }

        public string Username { get; set; }

        [Required(ErrorMessage = "Ime je potrebno")]
        [DisplayName("Ime")]
        [StringLength(160)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Prezime je potrebno")]
        [DisplayName("Prezime")]
        [StringLength(160)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Adresa je potrebna")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Grad je potreban")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Županija je potrebna")]
        [StringLength(40)]
        public string State { get; set; }

        [Required(ErrorMessage = "Poštanski broj je potreban")]
        [DisplayName("Poštanski broj")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Država je potrebna")]
        [StringLength(40)]
        public string Country { get; set; }

        [StringLength(24)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Email adresa je potrebna")]
        [DisplayName("Email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",
            ErrorMessage = "Email adresa nije ispravna.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string PaymentTransactionId { get; set; }

        [ScaffoldColumn(false)]
        public bool HasBeenShipped { get; set; }

        public List<NarudzbaDetalj> OrderDetails { get; set; }
    }
}
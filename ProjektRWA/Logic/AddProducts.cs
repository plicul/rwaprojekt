using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjektRWA.Models;

namespace ProjektRWA.Logic
{
    public class AddProducts
    {
        public bool AddProduct(string ProductName, string ProductDesc, string ProductPrice, string ProductCategory, string ProductImagePath)
        {
            var myProduct = new Artikal();
            myProduct.ArtikalIme = ProductName;
            myProduct.Opis = ProductDesc;
            myProduct.ArtikalCijena = Convert.ToDouble(ProductPrice);
            myProduct.ImagePath = ProductImagePath;
            myProduct.KategorijaID = Convert.ToInt32(ProductCategory);

            using (ArtikalContext _db = new ArtikalContext())
            {
                // Add product to DB.
                _db.Artikli.Add(myProduct);
                _db.SaveChanges();
            }
            // Success.
            return true;
        }
    }
}
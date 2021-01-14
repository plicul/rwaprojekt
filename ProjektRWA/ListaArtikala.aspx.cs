using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjektRWA.Models;
using System.Web.ModelBinding;

namespace ProjektRWA
{
    public partial class ListaArtikala : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Artikal> GetArtikli([QueryString("id")] int? kategorijaID)
        {
            var _db = new ProjektRWA.Models.ArtikalContext();
            IQueryable<Artikal> query = _db.Artikli;
            if (kategorijaID.HasValue && kategorijaID > 0)
            {
                query = query.Where(p => p.KategorijaID == kategorijaID);
            }

            return query;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using ProjektRWA.Models;

namespace ProjektRWA
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Kategorija> GetKategorije()
        {
            var _db = new ProjektRWA.Models.ArtikalContext();
            IQueryable<Kategorija> query = _db.Kategorije;
            return query;
        }

        protected void Toggle_Click1(object sender, EventArgs e)
        {
            if (Button1.CssClass == "toggleoff")
            {
                Button1.CssClass = "toggleon";
                Button1.Text = "-";
                return;
            }
            Button1.CssClass = "toggleoff";
            Button1.Text = "+";
        }
        protected void Toggle_Click2(object sender, EventArgs e)
        {
            if (Button2.CssClass == "toggleoff")
            {
                Button2.CssClass = "toggleon";
                Button2.Text = "-";
                return;
            }
            Button2.CssClass = "toggleoff";
            Button2.Text = "+";
        }
        protected void Toggle_Click3(object sender, EventArgs e)
        {
            if (Button3.CssClass == "toggleoff")
            {
                Button3.CssClass = "toggleon";
                Button3.Text = "-";
                return;
            }
            Button3.CssClass = "toggleoff";
            Button3.Text = "+";
        }
        protected void Toggle_Click4(object sender, EventArgs e)
        {
            if (Button4.CssClass == "toggleoff")
            {
                Button4.CssClass = "toggleon";
                Button4.Text = "-";
                return;
            }
            Button4.CssClass = "toggleoff";
            Button4.Text = "+";
        }
    }
}
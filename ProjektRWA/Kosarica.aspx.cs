﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProjektRWA.Models;
using ProjektRWA.Logic;
using System.Collections.Specialized;
using System.Collections;
using System.Web.ModelBinding;

namespace ProjektRWA
{
    public partial class Kosarica : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated)
            {
                CheckoutButton.Enabled = true;
            } else
            {
                CheckoutButton.Enabled = false;
            }

            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                decimal cartTotal = 0;
                cartTotal = usersShoppingCart.GetTotal();

                if (cartTotal > 0)
                {
                    lblTotal.Text = cartTotal + "kn";
                }
                else
                {
                    LabelTotalText.Text = "";
                    lblTotal.Text = "";
                    KosaricaTitle.InnerText = "Košarica je prazna";
                    UpdateButton.Visible = false;
                    CheckoutButton.Visible = false;
                }
            }
        }

        public List<CartItem> GetShoppingCartItems()
        {
            ShoppingCartActions actions = new ShoppingCartActions();
            return actions.GetCartItems();
        }

        public List<CartItem> UpdateCartItems()
        {
            using (ShoppingCartActions usersShoppingCart = new ShoppingCartActions())
            {
                String cartId = usersShoppingCart.GetCartId();

                ShoppingCartActions.ShoppingCartUpdates[] cartUpdates = new ShoppingCartActions.ShoppingCartUpdates[CartList.Rows.Count];
                for (int i = 0; i < CartList.Rows.Count; i++)
                {
                    IOrderedDictionary rowValues = new OrderedDictionary();
                    rowValues = GetValues(CartList.Rows[i]);
                    cartUpdates[i].ProductId = Convert.ToInt32(rowValues["ProductID"]);

                    CheckBox cbRemove = new CheckBox();
                    cbRemove = (CheckBox)CartList.Rows[i].FindControl("Remove");
                    cartUpdates[i].RemoveItem = cbRemove.Checked;

                    TextBox quantityTextBox = new TextBox();
                    quantityTextBox = (TextBox)CartList.Rows[i].FindControl("PurchaseQuantity");
                    cartUpdates[i].PurchaseQuantity = Convert.ToInt16(quantityTextBox.Text.ToString());
                }
                usersShoppingCart.UpdateShoppingCartDatabase(cartId, cartUpdates);
                CartList.DataBind();
                lblTotal.Text = String.Format("{0:c}", usersShoppingCart.GetTotal());
                return usersShoppingCart.GetCartItems();
            }
        }

        public static IOrderedDictionary GetValues(GridViewRow row)
        {
            IOrderedDictionary values = new OrderedDictionary();
            foreach (DataControlFieldCell cell in row.Cells)
            {
                if (cell.Visible)
                {
                    cell.ContainingField.ExtractValuesFromCell(values, cell, row.RowState, true);
                }
            }
            return values;
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateCartItems();
        }

        protected void CheckoutButton_Click(object sender, EventArgs e)
        {
            using (ProjektRWA.Logic.ShoppingCartActions usersShoppingCart =
              new ProjektRWA.Logic.ShoppingCartActions())
            {
                usersShoppingCart.EmptyCart();
                Response.Redirect("~/Checkout/CheckoutComplete.aspx");
            }
        }
    }
}
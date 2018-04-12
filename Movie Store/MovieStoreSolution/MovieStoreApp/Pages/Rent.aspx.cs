using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieStoreApp.Models;

namespace MovieStoreApp.Pages
{
    public partial class Rent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            using (var ctx = new MediaEntities())
            {
                // Befolka Customer Dropdown
                foreach (Customer C in ctx.Customers)
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = C.CustomerName;
                    newItem.Value = C.CustomerID.ToString();
                    Customers.Items.Add(newItem);
                }

            }

        }

        protected void btnRentMovie_Click(object sender, EventArgs e)
        {
            using (var ctx = new MediaEntities())
            {
                int ID = Convert.ToInt32(Request.QueryString["MovieID"].ToString());
                Movy mov = (from m in ctx.Movies where m.MovieId == ID select m).First();

                foreach (Customer C in ctx.Customers)
                {
                    ListItem newItem = new ListItem();
                    newItem.Text = C.CustomerName;
                    newItem.Value = C.CustomerID.ToString();
                    Customers.Items.Add(newItem);
                }

                RentedMovy RM = new RentedMovy();
                RM.MovieID = mov.MovieId;
                RM.CustomerID = Convert.ToInt16(Customers.SelectedValue);

                try
                {
                    // Try and confirm to date time. If not show error.
                    RM.RentedTo = DateTime.Parse(RentTo.Text);
                }
                catch (Exception ex)
                {
                    lblResult.Text = "Don't recognize the date format";
                    return;
                }

                ctx.RentedMovies.Add(RM);
                ctx.SaveChanges();

                // Show confirmation to user that movie is saved
                lblResult.Text = "Movie rented successfully";

            }
        }
    }
}
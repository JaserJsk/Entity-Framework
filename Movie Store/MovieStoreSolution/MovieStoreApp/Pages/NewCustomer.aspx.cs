using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MovieStoreApp.Models;

namespace MovieStoreApp.Pages
{
    public partial class NewCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){}

        /* ------------------------------------------------------------------------------- */
        protected void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerToDb();

            txtName.Text = "";
            txtAddress.Text = "";
            txtPhone.Text = "";
        }

        /* ------------------------------------------------------------------------------- */
        // Lägg till Customer Rad i tabelen
        private void AddCustomerToDb()
        {
            using (var ctx = new MediaEntities())
            {
                if (!string.IsNullOrEmpty(txtName.Text) &&
                    !string.IsNullOrEmpty(txtAddress.Text) &&
                    !string.IsNullOrEmpty(txtPhone.Text))
                {
                    Customer newCustomer = new Customer();
                    newCustomer.CustomerName = txtName.Text;
                    newCustomer.CustomerAdress = txtAddress.Text;
                    newCustomer.CustomerPhone = txtPhone.Text;

                    ctx.Customers.Add(newCustomer);
                    ctx.SaveChanges();
                }
            }

            // Printa ut resultat
            lblResult.Text = "Customer added successfully";

        }
    }
}
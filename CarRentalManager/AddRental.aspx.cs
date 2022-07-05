using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalManager.Models;

namespace CarRentalManager
{
    public partial class AddRental : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addRentalForm_InsertItem()
        {
            var item = new CarRentalManager.Models.RENTAL();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
                {
                    db.RENTALs.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void addRentalForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Rentals");
        }

        protected void onCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Rentals");
        }
    }
}
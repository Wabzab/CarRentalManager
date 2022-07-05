using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalManager.Models;

namespace CarRentalManager
{
    public partial class AddReturn : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addReturnForm_InsertItem()
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                var item = new CarRentalManager.Models.RETURN();
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    var rentalItem = db.RENTALs.Find(item.RENTAL_NO);
                    DateTime endDate = (DateTime)rentalItem.ED_DATE;
                    DateTime today = DateTime.Now;
                    item.ELAPSED_TIME = Math.Max((today - endDate).Days, 0);
                    item.FINE = item.ELAPSED_TIME * 500;
                    db.RETURNs.Add(item);
                    db.SaveChanges();                
                }
            }
        }

        protected void addReturnForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Rentals");
        }

        protected void onCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Rentals");
        }
    }
}
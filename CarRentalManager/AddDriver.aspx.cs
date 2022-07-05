using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalManager.Models;

namespace CarRentalManager
{
    public partial class AddDriver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addDriverForm_InsertItem()
        {
            var item = new DRIVER();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
                {
                    db.DRIVERs.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void addDriverForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Drivers");
        }

        protected void onCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Drivers");
        }
    }
}
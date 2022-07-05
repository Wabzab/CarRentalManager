using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalManager.Models;

namespace CarRentalManager
{
    public partial class AddInspector : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void addInspectorForm_InsertItem()
        {
            var item = new INSPECTOR();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
                {
                    db.INSPECTORs.Add(item);
                    db.SaveChanges();
                }
            }
        }

        protected void addInspectorForm_ItemInserted(object sender, FormViewInsertedEventArgs e)
        {
            Response.Redirect("~/Inspectors");
        }

        protected void onCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Inspectors");
        }
    }
}
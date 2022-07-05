using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CarRentalManager.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace CarRentalManager
{
    public partial class Inspectors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<INSPECTOR> inspectorsGrid_GetData()
        {
            DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities();
            var query = db.INSPECTORs;
            return query;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void inspectorsGrid_UpdateItem(INSPECTOR inspector)
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                INSPECTOR item = null;
                item = db.INSPECTORs.Find(inspector.INSPECTOR_NO);
                if (item == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", inspector.INSPECTOR_NO));
                    return;
                }
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void inspectorsGrid_DeleteItem(INSPECTOR inspector)
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                var item = new INSPECTOR { INSPECTOR_NO = inspector.INSPECTOR_NO };
                db.Entry(item).State = System.Data.EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", String.Format("Item with id {0} no longer exists in the database.", inspector.INSPECTOR_NO));
                }
            }
        }
    }
}
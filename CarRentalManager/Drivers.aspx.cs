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
    public partial class Drivers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<DRIVER> driversGrid_GetData()
        {
            DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities();
            var query = db.DRIVERs;
            return query;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void driversGrid_UpdateItem(DRIVER driver)
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                DRIVER item = null;
                item = db.DRIVERs.Find(driver.DRIVER_NO);
                if (item == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", driver.DRIVER_NO));
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
        public void driversGrid_DeleteItem(DRIVER driver)
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                var item = new DRIVER { DRIVER_NO = driver.DRIVER_NO };
                db.Entry(item).State = System.Data.EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", String.Format("Item with id {0} no longer exists in the database.", driver.DRIVER_NO));
                }
            }
        }
    }
}
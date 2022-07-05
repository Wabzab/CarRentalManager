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
    public partial class Cars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // ---------------------------------------  Car  --------------------------------------- //

        // Query to retrieve records
        public IQueryable<CAR> carsGrid_GetData()
        {
            DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities();
            var query = db.CARs;
            return query;
        }

        // Logic for updating a CAR record
        public void carsGrid_UpdateItem(CAR car)
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                CarRentalManager.Models.CAR item = null;
                item = db.CARs.Find(car.CAR_NO);
                if (item == null)
                {
                    // The item wasn't found
                    ModelState.AddModelError("", String.Format("Item with id {0} was not found", car.CAR_NO));
                    return;
                }
                TryUpdateModel(item);
                if (ModelState.IsValid)
                {
                    db.SaveChanges();
                }
            }
        }

        // Logic for deleting a CAR record
        public void carsGrid_DeleteItem(CAR car)
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                var item = new CAR { CAR_NO = car.CAR_NO };
                db.Entry(item).State = System.Data.EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", String.Format("Item with id {0} no longer exists in the database.", car.CAR_NO));
                }
            }
        }

        // ------------------------------------ Body Type -------------------------------------- //

        // Query to retrieve records
        public IQueryable<CarRentalManager.Models.CAR_BODY_TYPE> bodytypeGrid_GetData()
        {
            DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities();
            var query = db.CAR_BODY_TYPE;
            return query;
        }

        // -------------------------------------- Car Make ------------------------------------- //

        // Query to retrieve records
        public IQueryable<CarRentalManager.Models.CAR_MAKE> carmakeGrid_GetData()
        {
            DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities();
            var query = db.CAR_MAKE;
            return query;
        }

        // ------------------------------------------------------------------------------------- //

    }
}
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
    public partial class Rentals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<CarRentalManager.Models.RENTAL> rentalsGrid_GetData()
        {
            DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities();
            var query = db.RENTALs;
            return query;
        }

        public IQueryable<CarRentalManager.Models.RETURN> returnsGrid_GetData()
        {
            DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities();
            var query = db.RETURNs;
            return query;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void returnsGrid_DeleteItem(RETURN returns)
        {
            using (DB_CLDV_10082168Entities db = new DB_CLDV_10082168Entities())
            {
                var item = new RETURN { RENTAL_NO = returns.RENTAL_NO };
                db.Entry(item).State = System.Data.EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    ModelState.AddModelError("", String.Format("Item with id {0} no longer exists in the database.", returns.RENTAL_NO));
                }
            }
        }
    }
}
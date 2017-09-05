using System;
using System.Collections.Generic;
using System.Linq;
using TasteMakerPull.Entities;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull.DataAccess
{
    class TasteMakerDMStagingDA
    {
        public static void InsertGuestlist(List<GuestList> customers)
        {
            //using (var appDC = new PBRDMStagingDataContext())
            //{
            //    appDC.PBRShop_Customers.InsertAllOnSubmit(customers.Select(c => c.ToPBRShopCustomer()));

            //    appDC.SubmitChanges();
            //}
        }
    }
}

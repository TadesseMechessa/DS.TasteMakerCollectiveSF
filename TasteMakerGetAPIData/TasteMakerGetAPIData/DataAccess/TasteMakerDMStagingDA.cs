using System;
using System.Collections.Generic;
using System.Linq;
using TasteMakerPull.Entities;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull.DataAccess
{
   public class TasteMakerDMStagingDA
    {

        public static void InsertListings(List<Listings> listings)
        {
            using (var appDC = new DataClasses2DataContext())
            {
                appDC.Listings.InsertAllOnSubmit(listings.Select(e => e.ToTasteMakerListing()));

                appDC.SubmitChanges();
            }
        }
        public static void InsertGuestlist(List<GuestList> guestlists)
        {
            using (var appDC = new DataClasses2DataContext())
            {
                appDC.Guestlists.InsertAllOnSubmit(guestlists.Select(c => c.ToTasteMakerGuestList()));

                appDC.SubmitChanges();
            }
        }
        public static void InsertEventlist(List<Events> events)
        {
            using (var appDC = new DataClasses2DataContext())
            {
                appDC.Events.InsertAllOnSubmit(events.Select(c => c.ToTasteMakerEvent()));

                appDC.SubmitChanges();
            }
        }
    }
}

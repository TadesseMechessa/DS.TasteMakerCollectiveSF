using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteMakerPull.DataAccess;

namespace TasteMakerPull.Entities
{
    public class Events
    {
        public string id { get; set; }
        public int start_stamp { get; set; }
        public int end_stamp { get; set; }
        public string tz { get; set; }
        public string state { get; set; }
        public string listing_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public bool full { get; set; }
        public bool read_only { get; set; }
        public bool has_active_payment_plan { get; set; }
        public bool can_use_sepa { get; set; }
        public bool alternative_payment_methods { get; set; }
        public int count_attending { get; set; }
        public string host_id { get; set; }
        public IList<string> capacity_ids { get; set; }
        public IList<string> rate_ids { get; set; }
        public string payment_plan_id { get; set; }

        public TasteMakerPull.DataAccess.Event ToTasteMakerEvent()
        {
            return new TasteMakerPull.DataAccess.Event
            {

                id = id,
                start_stamp = start_stamp,
                end_stamp = end_stamp,
                tz = tz,
                state = state,
                listing_id = listing_id,
                start_time = start_time,
                end_time = end_time,
                full = full,
                read_only = read_only,
                has_active_payment_plan = has_active_payment_plan,
                can_use_sepa = can_use_sepa,
                alternative_payment_methods = alternative_payment_methods,
                count_attending = count_attending,
                host_id = host_id,
                payment_plan_id = payment_plan_id
            };
        }
    }

}

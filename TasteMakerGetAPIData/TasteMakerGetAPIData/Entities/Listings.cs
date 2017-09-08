using System;
using System.Collections.Generic;
using TasteMakerPull.DataAccess;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull.Entities
{

    public class Listings
    {
        public string id { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public string state { get; set; }
        public string description { get; set; }
        public string category_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }
        public double price { get; set; }
        public string capacity { get; set; }
        public bool has_active_discount_codes { get; set; }
        public string rate_type { get; set; }
        public string events_headline { get; set; }
        public string host_headline { get; set; }
        public string base_currency { get; set; }
        public string src_currency { get; set; }
        public bool is_active { get; set; }
        public string event_id { get; set; }
        public string cost_id { get; set; }

        public Listing  ToTasteMakerListing()
        {
            return new Listing
            {
                id = id,
                slug = slug,
                title = title,
                state = state,
                description = description,
                category_id = category_id,
                created_at = created_at,
                updated_at = updated_at,
                price = Convert.ToDecimal(price),
                capacity = capacity,
                has_active_discount_codes = has_active_discount_codes,
                rate_type = rate_type,
                events_headline = events_headline,
                host_headline = host_headline,
                base_currency = base_currency,
                src_currency = src_currency,
                is_active = is_active,
                event_id = event_id,
                cost_id = cost_id

            };
        }

    }
    //public class User
    //{
    //    public string id { get; set; }
    //    public string slug { get; set; }
    //    public string first_name { get; set; }
    //    public object last_name { get; set; }
    //    public object gender { get; set; }
    //    public DateTime created_at { get; set; }
    //    public DateTime updated_at { get; set; }
    //    public object description { get; set; }
    //    public string short_description { get; set; }
    //    public string locale { get; set; }
    //    public bool has_avatar { get; set; }
    //    public bool confirmed { get; set; }
    //    public object image_url { get; set; }
    //    public object image_url_500 { get; set; }
    //    public object image_url_160 { get; set; }
    //    public object image_url_50 { get; set; }
    //    public object cover_photo_url { get; set; }
    //}

    //public class LEvent
    //{
    //    public string id { get; set; }
    //    public int start_stamp { get; set; }
    //    public int end_stamp { get; set; }
    //    public string tz { get; set; }
    //    public string state { get; set; }
    //    public string listing_id { get; set; }
    //    public DateTime start_time { get; set; }
    //    public DateTime end_time { get; set; }
    //    public bool full { get; set; }
    //    public bool read_only { get; set; }
    //    public bool has_active_payment_plan { get; set; }
    //    public bool can_use_sepa { get; set; }
    //    public bool alternative_payment_methods { get; set; }
    //    public int count_attending { get; set; }
    //    public string host_id { get; set; }
    //    public IList<string> capacity_ids { get; set; }
    //    public IList<string> rate_ids { get; set; }
    //    public object payment_plan_id { get; set; }
    //}

    //public class AvailablePaymentMethods
    //{
    //    public bool alipay { get; set; }
    //    public bool bancontact { get; set; }
    //    public bool giropay { get; set; }
    //    public bool ideal { get; set; }
    //    public bool sepa { get; set; }
    //    public bool przelewy { get; set; }
    //}

    //public class Capacity
    //{
    //    public string id { get; set; }
    //    public int count_available { get; set; }
    //    public int count_attending { get; set; }
    //    public DateTime created_at { get; set; }
    //    public DateTime updated_at { get; set; }
    //    public string rate_id { get; set; }
    //    public string event_id { get; set; }
    //}

    //public class Rate
    //{
    //    public string id { get; set; }
    //    public double price { get; set; }
    //    public double src_price { get; set; }
    //    public int qty { get; set; }
    //    public int capacity { get; set; }
    //    public string name { get; set; }
    //    public string description { get; set; }
    //    public int? start_stamp { get; set; }
    //    public int? end_stamp { get; set; }
    //    public string listing_id { get; set; }
    //    public string client_group { get; set; }
    //    public string _type { get; set; }
    //    public string type { get; set; }
    //    public double min_price { get; set; }
    //    public double src_min_price { get; set; }
    //    public string state { get; set; }
    //    public int? min_tickets { get; set; }
    //    public int? max_tickets { get; set; }
    //    public bool discountable { get; set; }
    //    public string src_currency { get; set; }
    //    public int sort_index { get; set; }
    //    public object release_offset { get; set; }
    //    public object default_access_key { get; set; }
    //    public DateTime? start_time { get; set; }
    //    public DateTime? end_time { get; set; }
    //    public int credits { get; set; }
    //    public IList<string> capacity_ids { get; set; }
    //    public IList<object> host_field_ids { get; set; }
    //}

    //public class LMeta
    //{
    //    public int limit { get; set; }
    //    public int offset { get; set; }
    //    public int count { get; set; }
    //}

    //public class MainListing
    //{
    //    public IList<User> users { get; set; }
    //    public IList<Event> events { get; set; }
    //    public IList<Listing> listings { get; set; }
    //    public IList<Capacity> capacities { get; set; }
    //    public IList<Rate> rates { get; set; }
    //    public IList<object> payment_plans { get; set; }
    //    public Meta meta { get; set; }
    //}


}

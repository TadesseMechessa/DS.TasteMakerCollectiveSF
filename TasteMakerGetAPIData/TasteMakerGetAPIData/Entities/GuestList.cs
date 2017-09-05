using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull.Entities
{
    public class GuestList
    {
        public class Buyer
        {
            public string email { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class Attendee
        {
            public string email { get; set; }
            public string name { get; set; }
            public string id { get; set; }
        }

        public class TicketType
        {
            public string name { get; set; }
            public double price { get; set; }
            public string id { get; set; }
        }

        public class Order
        {
            public string discount_code { get; set; }
            public string id { get; set; }
            public string currency { get; set; }
        }

        public class Listing
        {
            public string title { get; set; }
            public string id { get; set; }
        }

        public class Event
        {
            public string id { get; set; }
            public int start_stamp { get; set; }
            public int end_stamp { get; set; }
        }

        public class Answers
        {
            public string name { get; set; }
            public string value { get; set; }
        }

        public class Guestlist
        {
            public string id { get; set; }
            public string token { get; set; }
            public string state { get; set; }
            public string updated_at { get; set; }
            public string created_at { get; set; }
            public Buyer buyer { get; set; }
            public Attendee attendee { get; set; }
            public TicketType ticket_type { get; set; }
            public Order order { get; set; }
            public Listing listing { get; set; }
            public Event @event { get; set; }
            public Answers answers { get; set; }
        }

        public class Data
        {
            public List<Guestlist> guestlist { get; set; }
        }

        public class Meta
        {
            public int count { get; set; }
            public int limit { get; set; }
            public int offset { get; set; }
        }

        public class RootObject
        {
            public Data data { get; set; }
            public Meta meta { get; set; }
        }
    }
}

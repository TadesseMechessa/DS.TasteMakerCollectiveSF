using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasteMakerPull.DataAccess;

namespace TasteMakerPull.Entities
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

        public class GListing
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

        public class GuestList
        {
    
        public string id { get; set; }
            public string token { get; set; }
            public string state { get; set; }
            public DateTime updated_at { get; set; }
            public DateTime created_at { get; set; }
            public Buyer buyer { get; set; }
            public Attendee attendee { get; set; }
            public TicketType ticket_type { get; set; }
            public Order order { get; set; }
            public GListing listing { get; set; }
            public Event @event { get; set; }
            public IList<Answers> answers { get; set; }
            public string BuyerId { get { return buyer != null ? buyer.id : null; } }
            public string BuyerEmail { get { return buyer.email; } }
            public string BuyerName { get { return buyer.name; } }

        public string AttendeeID { get { return attendee.id; } }
        public string AttendeeEmail { get { return attendee.email; } }
        public string AttendeeName { get { return attendee.name; } }

        public string TicketTypeID { get { return ticket_type.id; } }
        public string TicketTypeName { get { return ticket_type.name; } }
        public double TicketTypePrice { get { return ticket_type.price; } }

        public string OrderID { get { return order.id; } }
        public string OrderDiscountCode { get { return order.discount_code; } }
        public string OrderCurrency { get { return order.currency; } }

        public string ListingID { get { return listing.id; } }
        public string Listingtitle { get { return listing.title; } }

        public string EventID { get { return @event.id; } }
        public int Event_start_stamp { get { return @event.start_stamp; } }
        public int Event_end_stamp { get { return @event.end_stamp; } }

        public Guestlist ToTasteMakerGuestList()
        {
            return new Guestlist
            {
                id = id,
                token = token,
                state = state,
                updated_at = updated_at,
                created_at = created_at,
                Buyer_id = BuyerId,
                Buyer_email = BuyerEmail,
                Buyer_name = BuyerName,
                Attendee_id = AttendeeID,
                Attendee_email = AttendeeEmail,
                Attendee_name = AttendeeName,
                TicketType_id = TicketTypeID,
                TicketType_name = TicketTypeName,
                TicketType_price = Convert.ToDecimal(TicketTypePrice),
                Order_id = OrderID,
                Order_currency = OrderCurrency,
                Order_discount_code = OrderDiscountCode,
                Listing_id = ListingID,
                Listing_title = Listingtitle,
                Event_id = EventID,
                Event_start_stamp = Event_start_stamp,
                Event_end_stamp = Event_end_stamp

            };
        }

    }

        public class Data
        {
            public List<GuestList> guestlist { get; set; }
        }

        public class Meta
        {
            public int count { get; set; }
            public int limit { get; set; }
            public int offset { get; set; }
        }

        public class MainGuestList
        {
            public Data data { get; set; }
            public Meta meta { get; set; }
        }


    }


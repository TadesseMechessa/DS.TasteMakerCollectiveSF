using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasteMakerPull.Entities
{
    class Authorize
    {
        public class CoverPhotoUrls
        {
        }

        public class DefaultTokens
        {
        }

        public class ImageUrls
        {
        }

        public class RootObject
        {
            public string _id { get; set; }
            public object address { get; set; }
            public object android_app_version { get; set; }
            public bool background_check { get; set; }
            public object birthday { get; set; }
            public object blackberry_app_version { get; set; }
            public CoverPhotoUrls cover_photo_urls { get; set; }
            public object created_at { get; set; }
            public DefaultTokens default_tokens { get; set; }
            public object deleted_at { get; set; }
            public object description { get; set; }
            public object description_original { get; set; }
            public object education { get; set; }
            public object email { get; set; }
            public object email_provider { get; set; }
            public object eventjoy_buyer { get; set; }
            public object eventjoy_organizer { get; set; }
            public object eventjoy_user_id { get; set; }
            public object first_name { get; set; }
            public object galileo_id { get; set; }
            public object gender { get; set; }
            public object groups { get; set; }
            public bool hide_my_tickets_notice { get; set; }
            public ImageUrls image_urls { get; set; }
            public object invitation_code { get; set; }
            public string invited_by { get; set; }
            public object ios_app_version { get; set; }
            public object ios_version { get; set; }
            public bool is_business { get; set; }
            public bool is_host { get; set; }
            public string kraken_token { get; set; }
            public object languages { get; set; }
            public object last_active_at { get; set; }
            public object last_name { get; set; }
            public object likes { get; set; }
            public object locale { get; set; }
            public object manual_ref { get; set; }
            public object mutual_friend_counts_refreshed_at { get; set; }
            public object name { get; set; }
            public bool needs_completion { get; set; }
            public object phone { get; set; }
            public string phone_country_code { get; set; }
            public string profile_visibility { get; set; }
            public object pseudonym { get; set; }
            public bool publish_to_facebook { get; set; }
            public bool publish_to_twitter { get; set; }
            public bool receives_marketing_emails { get; set; }
            public object refreshed_at { get; set; }
            public string role { get; set; }
            public object school { get; set; }
            public object short_description { get; set; }
            public object signup_client { get; set; }
            public object signup_source { get; set; }
            public string slug { get; set; }
            public List<object> tag_ids { get; set; }
            public object ticketmanager_app_version { get; set; }
            public string tz { get; set; }
            public object updated_at { get; set; }
            public object utm_campaign { get; set; }
            public object utm_medium { get; set; }
            public object utm_source { get; set; }
            public object website { get; set; }
            public List<object> wishlisted_listing_ids { get; set; }
            public object work { get; set; }
        }
    }
}

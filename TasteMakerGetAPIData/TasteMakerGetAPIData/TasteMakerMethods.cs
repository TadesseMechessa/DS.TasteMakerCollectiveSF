using System;
using System.Collections.Generic;
using System.Net;
using TasteMakerPull.Entities;
using System.Net.Http;
using System.Web;
using System.IO;
using RestSharp;
using Newtonsoft.Json;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Threading.Tasks;
using TasteMakerPull.DataAccess;

namespace TasteMakerPull
{
    public class TasteMakerMethods
    {
        public  string GetAccessTokenAC(string clientId, string secret, string AUTHORIZATION_CODE, string redirect_uri)
        {
            var uri = string.Format("https://www.universe.com/oauth/token?grant_type=authorization_code&client_id={0}&client_secret={1}&code={2}&redirect_uri={3}", clientId, secret, AUTHORIZATION_CODE, redirect_uri);
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Method = "POST";
            webRequest.Accept = "application/json";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = reader.ReadToEnd();

                var TokenInfo = JsonConvert.DeserializeObject<Token>(result);
                return TokenInfo.access_token;

            }
        }
        public  string GetAccessTokenCC(string clientId, string secret)
        {
            var uri = string.Format("https://www.universe.com/oauth/token?grant_type=client_credentials&client_id={0}&client_secret={1}", clientId, secret);
            var webRequest = (HttpWebRequest)WebRequest.Create(uri);
            webRequest.Method = "POST";
            webRequest.Accept = "application/json";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();
            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var TokenInfo = JsonConvert.DeserializeObject<Token>(result);
                return TokenInfo.access_token;

            }
        }

        public  List<TokenInfo> GetTokenInfo(string accessToken)
        {
            var tokenInfo = new List<TokenInfo>();

            var webRequest = (HttpWebRequest)WebRequest.Create("https://www.universe.com/oauth/token/info");
            webRequest.Method = "GET";
            webRequest.Accept = "application/vnd.metric-list+json";
            webRequest.Headers.Add(string.Format("Authorization: Bearer {0}", accessToken));
            webRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();

            var result = string.Empty;

            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = reader.ReadToEnd();
                reader.Close();
            }

            tokenInfo.AddRange(JsonConvert.DeserializeObject<List<TokenInfo>>(result));

            return tokenInfo;


        }

        public  List<GuestList> GetGuestList(string accessToken)
        {
            
            var webRequest = (HttpWebRequest)WebRequest.Create("https://www.universe.com/api/v2/guestlists");
            webRequest.Method = "GET";
            webRequest.Accept = "application/vnd.metric-list+json";
            webRequest.Headers.Add(string.Format("Authorization: Bearer {0}", accessToken));
            webRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();
            List<GuestList> gl = new List<GuestList>();
            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var parsed = JObject.Parse(result);
                var listings = parsed["data"]["guestlist"].Children().ToList();
                foreach (var listing in listings)
                {
                    gl.Add(JsonConvert.DeserializeObject<GuestList>(listing.ToString()));
                }
                return gl; 
            }


        }
        public List<Listings> GetListings(string userId, string accessToken)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(String.Format("https://www.universe.com/api/v2/listings?user_id={0}", userId));
            webRequest.Method = "GET";
            webRequest.Accept = "application/vnd.metric-list+json";
            webRequest.Headers.Add(string.Format("Authorization: Bearer {0}", accessToken));
            webRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();
            List<Listings> gl = new List<Listings>();
            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var parsed = JObject.Parse(result);
                var listing = parsed["listings"].Children().ToList();
                foreach (var li in listing)
                {
                    gl.Add(JsonConvert.DeserializeObject<Listings>(li.ToString()));
                }
                return gl;
            }

        }
        public List<Events> GetEvents(string userId, string accessToken)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create(String.Format("https://www.universe.com/api/v2/listings?user_id={0}", userId));
            webRequest.Method = "GET";
            webRequest.Accept = "application/vnd.metric-list+json";
            webRequest.Headers.Add(string.Format("Authorization: Bearer {0}", accessToken));
            webRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();
            List<Events> gl = new List<Events>();
            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var parsed = JObject.Parse(result);
                var listing = parsed["events"].Children().ToList();
                foreach (var li in listing)
                {
                    gl.Add(JsonConvert.DeserializeObject<Events>(li.ToString()));
                }
                return gl;
            }


        }
        public  string CurrentUser(string accessToken)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create("https://www.universe.com/api/v2/current_user");
            webRequest.Method = "GET";
            webRequest.Accept = "application/vnd.metric-list+json";
            webRequest.Headers.Add(string.Format("Authorization: Bearer {0}", accessToken));
            webRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();

            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var parsed = JObject.Parse(result);
                var currrent_user = parsed["current_user"];
                var gl = JsonConvert.DeserializeObject<CurrentUser>(currrent_user.ToString());
                return gl.id;
            }
           


        }
    }
}

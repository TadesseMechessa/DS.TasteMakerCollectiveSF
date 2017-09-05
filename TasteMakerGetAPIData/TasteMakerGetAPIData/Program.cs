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



namespace TasteMakerPull

{

    class Tests

    {

           public static string GetAccessTokenAC(string clientId, string secret, string AUTHORIZATION_CODE, string redirect_uri)
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
        public static string GetAccessTokenCC(string clientId, string secret)
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

        public static List<TokenInfo>  GetTokenInfo(string accessToken)
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

        public static string GuestList(string accessToken)
        {
            var webRequest = (HttpWebRequest)WebRequest.Create("https://www.universe.com/api/v2/guestlists");
            webRequest.Method = "GET";
            webRequest.Accept = "application/vnd.metric-list+json";
            webRequest.Headers.Add(string.Format("Authorization: Bearer {0}", accessToken));
            webRequest.ContentType = "application/x-www-form-urlencoded";

            var httpResponse = (HttpWebResponse)webRequest.GetResponse();

            using (var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var gl = JsonConvert.DeserializeObject<Token>(result);
                return gl.ToString();
            }

            
        }

        static void Main(string[] args)
        {
            
            Tests T = new Tests();

            //string clientId = "4eae99d7317bf63ba9204accbb76635d528b6a12559464ed1789ef3e5e6ca2f2";
            //string secret = "04cecca5a04d31e17cd29979de2da585bfd7ce2e2036c41f276131dfbd2d2ef2";

            var clientId = TasteMakerPull.OrganizationSettings.GetClientID;
            var secret = TasteMakerPull.OrganizationSettings.GetClientSecret;

            //string AUTHORIZATION_CODE = "2477b8473fa06b4816fd33e91d782d2e388642539a4e31ce9560b65d28e7fcff";
            //string redirect_uri = "urn:ietf:wg:oauth:2.0:oob";
            string token = GetAccessTokenCC(clientId, secret);


            //var tokenInfo = GetTokenInfo(token);
            foreach (var Item in tokenInfo)
            {
                Console.WriteLine(Item.ToString());
                Console.ReadLine();
            }

           // string b = GuestList(token);
            //T.GetAccessToken3(AUTHORIZATION_CODE, clientId, secret);
            //b40fa03ac65c64b03d139178b75ea669f08ce2db8645fc90214a258cbc77a2f7
            //73b3bc49d7184f390b9e8823c8430f26c49deecbf586ef5a3009d4203850f157

            //Console.WriteLine(token.ToString()+ "/"+b.ToString());
            //Console.ReadLine();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Net;
using TasteMakerPull.Entities;
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

    class Tests

    {

       

        static void Main(string[] args)
        {

            TasteMakerMethods T = new TasteMakerMethods();
            
            var clientId = TasteMakerPull.OrganizationSettings.GetClientID;
            var secret = TasteMakerPull.OrganizationSettings.GetClientSecret;
            var tokenKey = TasteMakerPull.OrganizationSettings.GetToken;
            
            string token = T.GetAccessTokenCC(clientId, secret);

            string currentUser = T.CurrentUser(token);

            //Console.WriteLine(currentUser);
            //string guestlist = GuestList(token);
            List<GuestList> myguestLists = new List<GuestList>();
            List<Listings> myListings = new List<Listings>();
            List<Events> myEvents = new List<Events>();

            myListings = T.GetListings(currentUser, token);
            myEvents = T.GetEvents(currentUser, token);

            //TasteMakerDMStagingDA.InsertListings(myListings);
            TasteMakerDMStagingDA.InsertEventlist(myEvents);
            //TasteMakerDMStagingDA.InsertGuestlist(myguestLists)

            //myguestLists = GetGuestList(token);

            ;


            //var tokenInfo = GetTokenInfo(token);
            //foreach (var Item in token)
            //{
            //    Console.WriteLine(Item.ToString());
            //    Console.ReadLine();
            //}

            // string b = GuestList(token);
            //T.GetAccessToken3(AUTHORIZATION_CODE, clientId, secret);
            //b40fa03ac65c64b03d139178b75ea669f08ce2db8645fc90214a258cbc77a2f7
            //73b3bc49d7184f390b9e8823c8430f26c49deecbf586ef5a3009d4203850f157

            //Console.WriteLine(token.ToString()+ "/"+b.ToString());
            //Console.ReadLine();
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ApiFacebook.ConsoleAut.EntityAutent;
using Newtonsoft.Json;
using RestSharp;

namespace ApiFacebook.ConsoleAut
{
    public class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();

            var querosabe = program.Get2();

            var ok = querosabe;

        }


        public HotmartToken Get2()
        {
            return GetAuthorizeTokenHotmart();
        }


        public static HotmartToken GetAuthorizeTokenHotmart()
        {
            // Initialization.  
            string responseObj = string.Empty;

            string clientId = "34c73160-127f-417e-b133-275bc0d2c3ad";
            string clientSecret = "a74779a0-cd27-4896-86af-2940ccabeaf6";
            string Basic = "Basic MzRjNzMxNjAtMTI3Zi00MTdlLWIxMzMtMjc1YmMwZDJjM2FkOmE3NDc3OWEwLWNkMjctNDg5Ni04NmFmLTI5NDBjY2FiZWFmNg==";

                string URL = "https://api-sec-vlc.hotmart.com/security/oauth/token?grant_type=client_credentials&client_id=34c73160-127f-417e-b133-275bc0d2c3ad&client_secret=a74779a0-cd27-4896-86af-2940ccabeaf6";
                var request2 = new RestRequest(URL, Method.POST, DataFormat.Json);

                request2.AddHeader("Authorization", Basic);
                request2.AddHeader("Content-Type", "application /json");

                var clientRest = new RestClient();
                var resposta = clientRest.Post<HotmartToken>(request2);

                var tokenHotmart = JsonConvert.DeserializeObject<HotmartToken>(resposta.Content);

            return tokenHotmart;
                
        }



    }

}

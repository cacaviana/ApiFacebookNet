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

            string clientId = "das";
            string clientSecret = "dsa";
            string Basic = "Basic YFkMmQ0ZQ==";


            string URL = $"https://api-sec-vlc.hotmart.com/security/oauth/token?grant_type=client_credentials&client_id={clientId}&client_secret={clientSecret}";

            var request2 = new RestRequest(URL, Method.POST, DataFormat.Json);

                request2.AddHeader("Authorization", Basic);
                request2.AddHeader("Content-Type", "application /json");

                var clientRest = new RestClient();
                var resposta = clientRest.Post<HotmartToken>(request2);

                var tokenHotmart = JsonConvert.DeserializeObject<HotmartToken>(resposta.Content);
            var barenToken = tokenHotmart.access_token;

            return tokenHotmart;
                
        }



    }

}

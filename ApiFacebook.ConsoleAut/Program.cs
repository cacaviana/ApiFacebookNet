using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiFacebook.ConsoleAut
{
    public class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            
            var querosabe = program.Get2();

            var OK = querosabe;

        }


        public Task<string> Get2()
        {
            return GetAuthorizeTokenHotmart();
        }


        public static async Task<string> GetAuthorizeTokenHotmart()
        {
            // Initialization.  
            string responseObj = string.Empty;

            string clientId = "34c73160-127f-417e-b133-275bc0d2c3ad";
            string clientSecret = "a74779a0-cd27-4896-86af-2940ccabeaf6";
            string Basic = "Basic MzRjNzMxNjAtMTI3Zi00MTdlLWIxMzMtMjc1YmMwZDJjM2FkOmE3NDc3OWEwLWNkMjctNDg5Ni04NmFmLTI5NDBjY2FiZWFmNg==";

            // Posting.  
            using (var client = new HttpClient())
            {
                // Setting Base address.  
                client.BaseAddress = new Uri("https://api-sec-vlc.hotmart.com/security/oauth/token?grant_type=client_credentials&client_id=34c73160-127f-417e-b133-275bc0d2c3ad&client_secret=a74779a0-cd27-4896-86af-2940ccabeaf6");

                // Setting content type.  
                client.DefaultRequestHeaders.Add("Authorization", Basic);
                client.DefaultRequestHeaders.Add("Content-Type", "application/json");

              
                var request = new HttpRequestMessage()
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("https://api-sec-vlc.hotmart.com/security/oauth/token?grant_type=client_credentials&client_id=34c73160-127f-417e-b133-275bc0d2c3ad&client_secret=a74779a0-cd27-4896-86af-2940ccabeaf6")

                };

                request.Headers.Add("Content-Type", "application/json");
                request.Headers.Add("Authorization", Basic);


               // var response = await client.SendAsync(request);
               // HttpResponseMessage response = await client.SendAsync(request);
                // HttpContent content = response.Content;


                try
                {
                    var response = await client.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        // Reading Response.  

                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {

                    throw;
                }
                

                //var byteArray = Encoding.ASCII.GetBytes("YTBiZmU2NTktNzJkMC00OGFkLWE5ZTQtOTRmZTdkZDBiOWM4OjZjMTE5YzFkLTFjNjctNDQ2MS1hMTBmLTFhMTNjN2FkMmQ0ZQ==");
                //client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic: ", Convert.ToBase64String(byteArray));

                //var request = new HttpRequestMessage()
                //{
                //    Method = HttpMethod.Post,
                //    RequestUri = new Uri("https://api-sec-vlc.hotmart.com/security/oauth/token?grant_type=client_credentials&client_id=:a0bfe659-72d0-48ad-a9e4-94fe7dd0b9c8:&client_secret=:6c119c1d-1c67-4461-a10f-1a13c7ad2d4e")

                //};

                //request.Headers.Add("Content-Type", "application/json");
                //request.Headers.Add("Authorization", "Basic :YTBiZmU2NTktNzJkMC00OGFkLWE5ZTQtOTRmZTdkZDBiOWM4OjZjMTE5YzFkLTFjNjctNDQ2MS1hMTBmLTFhMTNjN2FkMmQ0ZQ==");


                //var response = await client.GetStringAsync(client.BaseAddress);

                //HttpResponseMessage response = await client.SendAsync(request);

                //  HttpContent content = response.Content;



                // Initialization.  
                //HttpResponseMessage response = new HttpResponseMessage();
                // List<KeyValuePair<string, string>> allIputParams = new List<KeyValuePair<string, string>>();

                // Convert Request Params to Key Value Pair.  

                // URL Request parameters.  
                //  HttpContent requestParams = new FormUrlEncodedContent(allIputParams);

                // HTTP POST  
                //response = await client.PostAsync(client.BaseAddress, content).ConfigureAwait(false);

                // Verification  
               
            }

            return responseObj;
        }



    }

}

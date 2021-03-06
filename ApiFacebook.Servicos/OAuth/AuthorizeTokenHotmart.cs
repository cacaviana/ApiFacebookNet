using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApiFacebook.Servicos.OAuth
{

    public class AuthorizeTokenHotmart
    {

        public Task<string> Get()
        {
            return GetAuthorizeTokenHotmart();
        }
        
        
        public static async Task<string> GetAuthorizeTokenHotmart()
        {
            // Initialization.  
            string responseObj = string.Empty;

            // Posting.  
            using (var client = new HttpClient())
            {
                // Setting Base address.  
                client.BaseAddress = new Uri("https://api-sec-vlc.hotmart.com/security/oauth/token?grant_type=client_credentials&client_id=:a0bfe659-72d0-48ad-a9e4-94fe7dd0b9c8:&client_secret=:6c119c1d-1c67-4461-a10f-1a13c7ad2d4e");
                
                // Setting content type.  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //var byteArray = Encoding.ASCII.GetBytes("Basic YTBiZmU2NTktNzJkMC00OGFkLWE5ZTQtOTRmZTdkZDBiOWM4OjZjMTE5YzFkLTFjNjctNDQ2MS1hMTBmLTFhMTNjN2FkMmQ0ZQ==");
                //  client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

                client.DefaultRequestHeaders.Add("Authorization", "Basic: YTBiZmU2NTktNzJkMC00OGFkLWE5ZTQtOTRmZTdkZDBiOWM4OjZjMTE5YzFkLTFjNjctNDQ2MS1hMTBmLTFhMTNjN2FkMmQ0ZQ==");

                //var request = new HttpRequestMessage()
                //{
                //    Method = HttpMethod.Post,
                //    RequestUri = new Uri("https://api-sec-vlc.hotmart.com/security/oauth/token?grant_type=client_credentials&client_id=:a0bfe659-72d0-48ad-a9e4-94fe7dd0b9c8:&client_secret=:6c119c1d-1c67-4461-a10f-1a13c7ad2d4e")

                //};

                //request.Headers.Add("Content-Type", "application/json");
                //request.Headers.Add("Authorization", "Basic :YTBiZmU2NTktNzJkMC00OGFkLWE5ZTQtOTRmZTdkZDBiOWM4OjZjMTE5YzFkLTFjNjctNDQ2MS1hMTBmLTFhMTNjN2FkMmQ0ZQ==");

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                    
                HttpContent content = response.Content;

                // Initialization.  
                //HttpResponseMessage response = new HttpResponseMessage();
                // List<KeyValuePair<string, string>> allIputParams = new List<KeyValuePair<string, string>>();

                // Convert Request Params to Key Value Pair.  

                // URL Request parameters.  
              //  HttpContent requestParams = new FormUrlEncodedContent(allIputParams);

                // HTTP POST  
                response = await client.PostAsync(client.BaseAddress,content).ConfigureAwait(false);

                // Verification  
                if (response.IsSuccessStatusCode)
                {
                    // Reading Response.  

                }
            }

            return responseObj;
        }


    }


}

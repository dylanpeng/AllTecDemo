using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace OAuthConsoleTest
{
    

    class OAuthClientTest
    {
        private HttpClient _httpClient;
        private string token;
        
        public OAuthClientTest()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("http://localhost");
        }

        public async Task<string> GetAccessToken()
        {
            var clientId = "1234";
            var clientSecret = "5678";

            var parameters = new Dictionary<string, string>();
            parameters.Add("grant_type", "password");
            parameters.Add("username", "Admin");
            parameters.Add("password", "123456");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                "Basic",
                Convert.ToBase64String(Encoding.ASCII.GetBytes(clientId + ":" + clientSecret))
                );

            var response = await _httpClient.PostAsync("OAuthTest/token", new FormUrlEncodedContent(parameters));
            var responseValue = await response.Content.ReadAsStringAsync();
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JObject.Parse(responseValue)["access_token"].Value<string>();
            }
            else
            {
                Console.WriteLine(responseValue);
                return string.Empty;
            }
        }

        public async Task Call_WebAPI_By_Resource_Owner_Password_Credentials_Grant()
        {
            if(string.IsNullOrEmpty(token))
                token = await GetAccessToken();
            Console.WriteLine(token);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            Console.WriteLine(await (await _httpClient.GetAsync("OAuthTest/api/Values")).Content.ReadAsStringAsync());
        }
    }
}

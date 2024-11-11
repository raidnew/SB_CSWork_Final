using CSFinal_WebClient.Auth;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CSWorkFinal_WebClient.Data
{
    public class AuthConnector
    {
        private readonly string _serverAddress;
        private HttpClient HttpClient { get; set; }

        public AuthConnector()
        {
            _serverAddress = "http://localhost:5000";
            HttpClient = new HttpClient();
        }
        public void Login(UserLoginData authData)
        {
            HttpResponseMessage message = HttpClient.PostAsync(
                requestUri: GetUrl("Authentication"),
                content: new StringContent(JsonConvert.SerializeObject(authData), Encoding.UTF8,
                mediaType: "application/json")
            ).Result;
        }

        private string GetUrl(string action)
        {
            return $"{_serverAddress}/api/{action}";
        }
    }
}

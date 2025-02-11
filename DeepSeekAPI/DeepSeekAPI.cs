using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using RestSharp;

namespace DeepSeekAPI
{
    public class DeepSeekApi
    {
        private string apiKey;

        public DeepSeekApi(string apiKey)
        {
            this.apiKey = apiKey;
        }

        public async Task<Tuple<object, string>> GetModelList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.deepseek.com/models");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", "Bearer " + apiKey);
            var response = await client.SendAsync(request);

            string jsonContent = await response.Content.ReadAsStringAsync();
            if (jsonContent.Contains("error"))
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessage)), "error");
            }
            else
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekModelReturnValue)), "data");
            }
        }

        public async Task<Tuple<object, string>> Chat(string message, string model)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, "https://api.deepseek.com/chat/completions");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", "Bearer " + apiKey);

            DeepSeekChatRequest msgReq = new DeepSeekChatRequest(model);
            msgReq.messages.Add(new DeepSeekChatRequestMessage()
            {
                content = message,
                role = "user"
            });
            string requestStr = JsonSerializer.Serialize(msgReq);

            var content = new StringContent(requestStr,
                                    Encoding.UTF8,
                                    "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);

            string jsonContent = await response.Content.ReadAsStringAsync();
            if (jsonContent.Contains("error"))
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessageReturnValue)), "error");
            }
            else
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekChatResponseMessage)), "data");
            }
        }

        public async Task<Tuple<object, string>> GetBalance()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://api.deepseek.com/user/balance");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", "Bearer " + apiKey);
            var response = await client.SendAsync(request);

            string jsonContent = await response.Content.ReadAsStringAsync();
            if (jsonContent.Contains("error"))
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessage)), "error");
            }
            else
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekBalance)), "data");
            }
        }
    }
}

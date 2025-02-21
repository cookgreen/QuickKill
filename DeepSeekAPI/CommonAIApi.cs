using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using RestSharp;

namespace DeepSeekAPI
{
    public class CommonAIApi : IAIApiProvider
    {
        private string apiKey;
        protected string baseUrl;

        public virtual string ProviderName { get { return "UNKNOWN"; } }
        public string ApiKey { get { return apiKey; } }

        public CommonAIApi(string apiKey)
        {
            this.apiKey = apiKey;
            baseUrl = "YourBaseApiUrl";
        }

        public async Task<DeepSeekCallResult> GetModelList()
        {
            object data = null;

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/models");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", "Bearer " + apiKey);
            var response = await client.SendAsync(request);

            string jsonContent = await response.Content.ReadAsStringAsync();
            if (jsonContent.Contains("error"))
            {
                data = JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessage));
                return new DeepSeekCallResult(false, data);
            }
            else
            {
                data = JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekModelReturnValue));
                return new DeepSeekCallResult(false, data);
            }
        }

        public async Task<DeepSeekCallResult> Chat(string message, string model)
        {
            object data = null;

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, baseUrl + "/chat/completions");
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
                data = JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessageReturnValue));
                return new DeepSeekCallResult(false, data);
            }
            else
            {
                data = JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekChatResponseMessage));
                return new DeepSeekCallResult(true, data);
            }
        }

        public async Task<DeepSeekCallResult> GetBalance()
        {
            object data = null;

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, baseUrl + "/user/balance");
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Authorization", "Bearer " + apiKey);
            var response = await client.SendAsync(request);

            string jsonContent = await response.Content.ReadAsStringAsync();
            if (jsonContent.Contains("error"))
            {
                data = JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessage));
                return new DeepSeekCallResult(false, data);
            }
            else
            {
                data = JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekBalance));
                return new DeepSeekCallResult(true, data);
            }
        }
    }

    public class DeepSeekCallResult
    {
        private bool result;
        private object data;

        public bool Result { get { return result; } }
        public object Data { get { return data; } }

        public DeepSeekCallResult(bool result, object data)
        {
            this.result = result;
            this.data = data;
        }
    }
}

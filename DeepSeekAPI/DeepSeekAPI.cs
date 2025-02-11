using System.Net.Http.Json;
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
            var content = new StringContent("{\n  \"messages\": [\n    {\n      \"content\": \"You are a helpful assistant\",\n      \"role\": \"system\"\n    },\n    {\n      \"content\": \"Hi\",\n      \"role\": \"user\"\n    }\n  ],\n  \"model\": \"deepseek-chat\",\n  \"frequency_penalty\": 0,\n  \"max_tokens\": 2048,\n  \"presence_penalty\": 0,\n  \"response_format\": {\n    \"type\": \"text\"\n  },\n  \"stop\": null,\n  \"stream\": false,\n  \"stream_options\": null,\n  \"temperature\": 1,\n  \"top_p\": 1,\n  \"tools\": null,\n  \"tool_choice\": \"none\",\n  \"logprobs\": false,\n  \"top_logprobs\": null\n}", null, "application/json");
            request.Content = content;
            var response = await client.SendAsync(request);

            string jsonContent = await response.Content.ReadAsStringAsync();
            if (jsonContent.Contains("error"))
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessage)), "error");
            }
            else
            {
                return new Tuple<object, string>(JsonSerializer.Deserialize(jsonContent, typeof(DeepSeekErrorMessage)), "data");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class DeepSeekChatMessage
    {
        public string content { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;
    }

    public class DeepSeekChatRequest
    {
        public List<DeepSeekChatMessage> messages { get; set; }
        public string model {  get; set; }
        public int frequency_penalty {  get; set; }
        public int max_tokens {  get; set; }
        public int presence_penality {  get; set; }
        public int response_penality { get; set; }
        public DeepSeekChatResponseFormat response_format { get; set; }
        public string? stop {  get; set; }
        public bool stream {  get; set; }
        public string? stream_options {  get; set; }
        public int temperature {  get; set; }
        public int top_p {  get; set; }
        public string? tools {  get; set; }
        public string tool_choice {  get; set; }
        public bool logprobs {  get; set; }
        public string? top_logprobs {  get; set; }

        public DeepSeekChatRequest(string model)
        {
            messages = new List<DeepSeekChatMessage>();
            this.model = model;
            frequency_penalty = 0;
            max_tokens = 2048;
            presence_penality = 0;
            response_format = new DeepSeekChatResponseFormat();
            stop = null;
            stream = false;
            stream_options = null;
            temperature = 1;
            tools = null;
            tool_choice = "none";
            logprobs = false;
            top_logprobs = null;
        }
    }

    public class DeepSeekChatResponseFormat
    {
        public string type { get; set;}

        public DeepSeekChatResponseFormat()
        {
            type = "text";
        }
    }
}

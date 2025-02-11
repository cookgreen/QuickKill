using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class DeepSeekChatResponseMessage
    {
        public string id {  get; set; }
        public List<DeepSeekChatResponseChoice> choices { get; set; }
        public int created;
        public string model;
        public DeepSeekChatUsage usage {  get; set; }
    }

    public class DeepSeekChatResponseChoice
    {
        public string finish_reason { get; set; }
        public int index { get; set; }
        public DeepSeekChatRequestMessage message { get; set; }
    }

    public class DeepSeekChatUsage
    {
        public int completion_tokens { get; set; }
        public int prompt_tokens { get; set; }
        public int total_tokens { get; set; }
    }
}

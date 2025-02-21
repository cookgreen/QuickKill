using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class DeepSeekApi : CommonAIApi
    {
        public override string ProviderName { get { return "DeepSeek"; } }

        public DeepSeekApi(string apiKey) : base(apiKey)
        {
            baseUrl = "https://api.deepseek.com";
        }
    }
}

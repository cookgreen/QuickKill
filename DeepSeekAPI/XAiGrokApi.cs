using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class XAiGrokApi : CommonAIApi
    {
        public override string ProviderName { get { return "Grok"; } }

        public XAiGrokApi(string apiKey) : base(apiKey)
        {
            baseUrl = "https://api.x.ai/v1";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class NvidiaDeepSeekApi : DeepSeekApi
    {
        public override string ProviderName { get { return "Nvidia"; } }

        public NvidiaDeepSeekApi(string apiKey) : base(apiKey)
        {
            baseUrl = "https://integrate.api.nvidia.com/v1";
        }
    }
}

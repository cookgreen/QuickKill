using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class DeepSeekApiFactory
    {
        private static DeepSeekApiFactory instance;
        public static DeepSeekApiFactory Instance
        {
            get
            {
                if (instance == null)
                    instance = new DeepSeekApiFactory();
                return instance;
            }
        }

        public IAIApiProvider CreateApiByProvider(string apiKey, string provider)
        {
            IAIApiProvider api;
            switch (provider) 
            {
                case "DeepSeek":
                    api = new DeepSeekApi(apiKey);
                    break;
                case "Nvidia":
                    api = new NvidiaDeepSeekApi(apiKey);
                    break;
                case "xAI":
                    api = new XAiGrokApi(apiKey);
                    break;
                default:
                    throw new ArgumentException("Can't find specific provider '" + provider + "'!");
            }
            return api;
        }
    }
}

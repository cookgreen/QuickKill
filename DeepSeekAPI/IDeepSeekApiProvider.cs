using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public interface IDeepSeekApiProvider
    {
        public string ProviderName {  get; }
        public string ApiKey { get; }
    }
}

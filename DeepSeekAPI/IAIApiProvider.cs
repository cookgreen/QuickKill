using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public interface IAIApiProvider
    {
        public string ProviderName {  get; }
        public string ApiKey { get; }

        Task<DeepSeekCallResult> GetModelList();

        Task<DeepSeekCallResult> Chat(string message, string model);

        Task<DeepSeekCallResult> GetBalance();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class DeepSeekBalance
    {
        public bool is_avaiable { get; set; }
        public List<DeepSeekBalanceInfo> balance_infos { get; set; } = null;
    }

    public class DeepSeekBalanceInfo
    {
        public string currency { get; set; } = string.Empty;
        public string total_balance { get; set; } = string.Empty;
        public string granted_balance { get; set; } = string.Empty;
        public string topped_up_balance {  get; set; } = string.Empty;
    }
}

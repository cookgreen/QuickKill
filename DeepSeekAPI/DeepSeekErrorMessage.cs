using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class DeepSeekErrorMessage
    {
        public string message {  get; set; }
        public string type { get; set; }
        public string? param { get; set; } = null;
        public string code {  get; set; }
    }
}

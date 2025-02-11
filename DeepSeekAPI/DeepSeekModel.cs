using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeepSeekAPI
{
    public class DeepSeekModel
    {
        public string id { get; set; }

        [JsonPropertyName("object")]
        public string obj { get; set; }
        public string owned_by {  get; set; }
    }

    public class DeepSeekModelReturnValue
    {
        [JsonPropertyName("object")]
        public string obj { get; set; }
        public List<DeepSeekModel> data { get; set; }
    }
}

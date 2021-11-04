using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Cryptografie.Models
{
    public class DecodedMessage
    {
        [JsonProperty("plaintext")]
        public string plaintext { get; set; }
    }
}

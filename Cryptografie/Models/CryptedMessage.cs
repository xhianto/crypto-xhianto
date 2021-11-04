using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cryptografie.Models
{
    public class CryptedMessage
    {
        public string kid { get; set; }
        public string key { get; set; }
        public string challenge { get; set; }
        public string nonce { get; set; }
    }
}

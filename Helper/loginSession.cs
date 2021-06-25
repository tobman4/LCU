using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCU.Helper {
    public class loginSession {
        public long summonerId { get; set; }
        public long accountId { get; set; }
        public bool connected { get; set; }
        public string state { get; set; }
        public string username { get; set; }
    }
}

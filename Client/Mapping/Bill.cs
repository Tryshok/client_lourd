using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Mapping
{
    class Bill
    {
        public int id { get; set; }
        public string clientid { get; set; }
        public int value { get; set; }
        public string description { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Mapping
{
    class Product
    {
        public int id { get; set; }
        public int position { get; set; }
        public string name { get; set; }
    }

    class Parts
    {
        public int id { get; set; }
        public int product { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}

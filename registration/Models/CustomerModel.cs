using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace registration.Models
{
    public class CustomerModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string st_addr { get; set; }
        public string city { get; set; }
        public string zip { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
    }
}

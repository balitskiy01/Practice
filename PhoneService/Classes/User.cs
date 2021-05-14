using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneService.Classes {
    public class User {
        public string Phone { get; set; }
        public string PIB { get; set; }
        public string Address { get; set; }
        public string CodePass { get; set; }
        public string Password { get; set; }
        public List<string> Calls { get; set; }
        public int Rate { get; set; }
        public int Money { get; set; }
    }
}

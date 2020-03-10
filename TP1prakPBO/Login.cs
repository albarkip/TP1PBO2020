using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1prakPBO
{
    class Login
    {
        public string loginnama { get; set; }
        public string kuncilogin { get; set; }
        public Login(string a, string b)
        {
            this.loginnama = a;
            this.kuncilogin = b;
        }
        public Login() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_2_OPP_Basic
{
    internal class HocSinh
    {
        //Auto-Implemented Properties
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Phương thức Tostring
        public override string ToString()
        {
            return this.Name + "\t" + this.Email + "\t" + this.Password ;
        }
    }
}

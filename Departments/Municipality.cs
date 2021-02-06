using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{
    class Municipality
    {
        private string name { get; set; }
        private string code { get; set; }
        private string type { get; set; }

        public Municipality(string name, string code,string type)
        {
            this.name = name;
            this.type = type;
            this.code = code;
        }
    }
}

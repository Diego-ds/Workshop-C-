using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Departments
{   

    class Department
    {
        private string code { get; set; }
        private string name { get; set; }

        private int Length { get; set; }

        private List<Municipality> municipalities { get; set; }

        public Department(string code,string name)
        {
            this.code = code;
            this.name = name;
            municipalities = new List<Municipality>();
            this.Length = 0;
        }

        public void AddMunicipality(string name,string code,string type)
        {
            municipalities.Add(new Municipality(name, code, type));
            Length++;
        }

        public string getName()
        {
            return name;
        }

        public string getCode()
        {
            return code;
        }
        public List<Municipality> GetMunicipalities()
        {
            return municipalities;
        }

        public int getSize()
        {
            return Length;
        }
    }
}

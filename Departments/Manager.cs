using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Departments
{
    class Manager
    {
        private Hashtable deps;

        public Manager()
        {
            deps = new Hashtable();
        }

        public void addDepartment(string name,string code)
        {
            if (!deps.ContainsKey(code))
            {
                deps.Add(code, new Department(code, name));
            }   
        }

        public void addMunicipality(string codeDept,string name,string code,string type)
        {
            Department temp = (Department)deps[codeDept];
            temp.AddMunicipality(name, code, type);
        }

        public Hashtable getDeps()
        {
            return deps;
        }
    }
}

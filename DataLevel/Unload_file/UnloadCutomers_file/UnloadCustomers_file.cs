using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public class UnloadCustomers_file:IUnloadCustomers_file
    {
        public UnloadCustomers_file()
        {
        }
        public void UnloadCustomersToFile(string text,string path)
        {
            File.WriteAllText(path, text);
        }
    }
}

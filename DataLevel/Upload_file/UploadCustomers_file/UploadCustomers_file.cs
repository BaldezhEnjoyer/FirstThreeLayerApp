using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLevel
{
    public class UploadCustomers_file:IUploadCustomers_file
    {
        public UploadCustomers_file()
        { }
        public string UploadCustomersToFile(string path)
        {
            using (StreamReader fileIn = new StreamReader(path))
            {
                return fileIn.ReadToEnd();
            }
        }
    }
}

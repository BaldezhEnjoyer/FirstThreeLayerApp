using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DataLevel
{
    public class UploadHalls_file:IUploadHalls_file
    {
        public UploadHalls_file() 
        { }
        public string UploadHallsToFile(string path)
        {
            using (StreamReader fileIn = new StreamReader(path))
            {
                return fileIn.ReadToEnd();
            }
        }
    }
}

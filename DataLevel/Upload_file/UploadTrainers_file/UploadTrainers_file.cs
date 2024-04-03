using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DataLevel
{
    public class UploadTrainers_file:IUploadTrainers_file
    {
        public UploadTrainers_file() 
        { }
        public string UploadTrainersToFile(string path)
        {
            using (StreamReader fileIn = new StreamReader(path))
            {
                return fileIn.ReadToEnd();
            }
        }
    }
}

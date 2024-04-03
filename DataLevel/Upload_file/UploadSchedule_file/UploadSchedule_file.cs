using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public class UploadSchedule_file: IUploadSchedule_file
    {
        public UploadSchedule_file() 
        { }
        public string UploadScheduleToFile(string path)
        {
            using (StreamReader fileIn = new StreamReader(path))
            {
                return fileIn.ReadToEnd();
            }
        }
    }
}

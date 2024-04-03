using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public class UnloadSchedule_file:IUnloadSchedule_file
    {
        public UnloadSchedule_file()
        {
        }
        public void UnloadScheduleToFile(string text, string path)
        {
            File.WriteAllText(path, text);
        }
    }
}

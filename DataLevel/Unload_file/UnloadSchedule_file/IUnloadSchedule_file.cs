using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public interface IUnloadSchedule_file
    {
        void UnloadScheduleToFile(string text, string path);
    }
}

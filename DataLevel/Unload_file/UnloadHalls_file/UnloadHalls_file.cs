using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public class UnloadHalls_file:IUnloadHalls_file
    {
        public UnloadHalls_file()
        {
        }
        public void UnloadHallsToFile(string text, string path)
        {
            File.WriteAllText(path, text);
        }
    }
}

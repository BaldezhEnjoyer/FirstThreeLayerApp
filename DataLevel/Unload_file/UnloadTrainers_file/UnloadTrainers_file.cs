using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLevel
{
    public class UnloadTrainers_file:IUnloadTrainers_file
    {
        public UnloadTrainers_file()
        {
        }
        public void UnloadTrainersToFile(string text, string path)
        {
            File.WriteAllText(path, text);
        }
    }
}

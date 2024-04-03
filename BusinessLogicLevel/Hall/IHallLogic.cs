using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicLevel
{
    public interface IHallLogic
    {
        string Name
        {
            get;
            set;
        }
        int Id
        {
            get;
            set;
        }
        string PrintHallInfo();
        IHallLogic CreateHall(string name);
        IHallLogic CreateHall(int id,string name);
        IHallLogic UploadHall(int id, string name);
    }
}

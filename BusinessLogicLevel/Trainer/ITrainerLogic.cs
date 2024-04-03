using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicLevel
{
    public interface ITrainerLogic
    {
        string Name
        {
            get;
            set;
        }
        string Surname
        {
            get;
            set;
        }
        string Work
        {
            get;
            set;
        }
        int Age
        {
            get;
            set;
        }
        int Id
        {
            get;
            set;
        }
        string PrintTrainerInfo();
        ITrainerLogic CreateTrainer(string name, string surname, int age, string work);
        ITrainerLogic CreateTrainer(int id,string name, string surname, int age, string work);
        ITrainerLogic UploadTrainer(int id, string name, string surname, int age,string work);
    }
}

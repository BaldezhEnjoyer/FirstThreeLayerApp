using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel
{
    public interface IBaseLogic
    {
        List<ILessonsLogic> Schedule
        {
            get;
            set;
        }
          List<ICustomerLogic> Customers
        {
            get;
            set;
        }
          List<IHallLogic> Halls
        {
            get;
            set;
        }
          List<ITrainerLogic> Trainers
        {
            get;
            set;
        }
        string Path
        {
            get;
            set;
        }
        string Fl
        {
            get;
            set;
        }
        void AddCustomer(string na, string su, int ag);
        string FindCustomer(string na,string su,int ag);
        void DeleteCustomer(string na, string su, int ag);
        string PrintAllCustomers();
        string PrintCustomerSchedule(int id, int year, int month, int day);
        string PrintCustomerSchedule(int id, int year, int month);
        void AddTrainer(string na, string su, int ag,string work);
        string FindTrainer(string na, string su, int ag);
        void DeleteTrainer(string na, string su, int ag);
        string PrintAllTrainers();
        string PrintTrainerSchedule(int id, int year, int month, int day);
        string PrintTrainerSchedule(int id, int year, int month);
        void AddHall(string na);
        string FindHall(string su);
        void DeleteHall(string na);
        string PrintAllHalls();
        string PrintHallSchedule(int id, int year, int month, int day);
        string PrintHallSchedule(int id, int year, int month);
        string ShowSchedule();
        public void AddTrainerForLesson(int id, string name, string surname, int age, string work);
        public void AddHallForLesson(int id, string name);
        public void AddCustomersForLesson(int id, string name, string surname, int age);
        void CreateLesson(int year, int month, int day, int hour, int minute);
        IBaseLogic CreateBase();
        void UnloadCustomers();
        void UnloadTrainers();
        void UnloadHalls();
        void UnloadSchedule();
        public void UnloadSchedule(string text);
        void UploadCustomers();
        void UploadTrainers();
        void UploadHalls();
        void UploadSchedule();
    }
}

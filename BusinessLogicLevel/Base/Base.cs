using System;
using System.Collections.Generic;
using System.Text;
using DataLevel;
using BusinessLogicLevel;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace BusinessLogicLevel
{
    public class Base:IBaseLogic
    {
        private IUnloadCustomers_file uncus = new UnloadCustomers_file();
        private IUnloadTrainers_file untr = new UnloadTrainers_file();
        private IUnloadHalls_file unha = new UnloadHalls_file();
        private IUnloadSchedule_file unsched = new UnloadSchedule_file();
        private IUploadCustomers_file upcus = new UploadCustomers_file();
        private IUploadTrainers_file uptr = new UploadTrainers_file();
        private IUploadHalls_file upha = new UploadHalls_file();
        private IUploadSchedule_file upsched = new UploadSchedule_file();
        private   List<ICustomerLogic> customers = new List<ICustomerLogic>();
        private   List<IHallLogic> halls = new List<IHallLogic>();
        private   List<ILessonsLogic> schedule = new List<ILessonsLogic>();
        private   List<ITrainerLogic> trainers = new List<ITrainerLogic>();
        private string path;
        private IHallLogic cash_hall = new Hall();
        private ITrainerLogic cash_trainer = new Trainer();
        private List<ICustomerLogic> cash_customers = new List<ICustomerLogic>();
        public string fl;

        ///////////// CUSTOMER PART
        public Base()
        {
        }
        public   void AddCustomer(string na, string su, int ag)
        {
            ICustomerLogic cu = new Customer();
            cu = cu.CreateCustomer(na, su, ag);
            this.customers.Add(cu);
        }
        public   string FindCustomer(string na, string su,int ag)
        {
            StringBuilder tmp = new StringBuilder();
            foreach (ICustomerLogic person in customers)
            {
                if (person.Surname == su && person.Name == na && person.Age==ag)
                {
                    tmp.Append( person.PrintCustomerInfo());
                    break;
                }
            }
            if (tmp.ToString()=="")
            {
                tmp.Append("Такого клиента нет!");
            }
            return tmp.ToString();
        }
        public  void DeleteCustomer(string na, string su, int ag)
        {
            foreach (ICustomerLogic person in customers)
            {
                if (person.Surname == su && person.Name == na && person.Age == ag)
                {
                    customers.Remove(person);
                    break;
                }
            }
        }
        public   string PrintAllCustomers()
        {
            StringBuilder tmp =new StringBuilder();
            foreach (ICustomerLogic person in customers)
            {
                tmp.Append(person.PrintCustomerInfo());
            }
            return tmp.ToString();
        }
        public   string PrintCustomerSchedule(int id,int year,int month,int day)
        {
            StringBuilder tzmp = new StringBuilder();
            List<ILessonsLogic>temp = schedule.FindAll(x => x.Date.Year == year && x.Date.Month == month && x.Date.Day == day && x.Customers.Find(x => x.Id == id).Id == id);
            foreach (ILessonsLogic tmp in temp)
            {
                tzmp.Append(tmp.PrintLesson());
            }
            return tzmp.ToString();
        }
        public   string PrintCustomerSchedule(int id, int year, int month)
        {
            StringBuilder tzmp = new StringBuilder();
            List<ILessonsLogic> temp = schedule.FindAll(x => x.Date.Year == year && x.Date.Month == month && x.Customers.Find(x => x.Id == id).Id == id);
            foreach (ILessonsLogic tmp in temp)
            {
                tzmp.Append(tmp.PrintLesson());
            }
            return tzmp.ToString();
        }
        /////////////
        ///////////// TRAINER PART
        public   void AddTrainer(string na, string su, int ag,string work)
        {
            ITrainerLogic tr = new Trainer();
            tr = tr.CreateTrainer(na, su, ag,work);
            this.trainers.Add(tr);
        }
        public  string FindTrainer(string na, string su, int ag)
        {
            StringBuilder temp = new StringBuilder();
            foreach (ITrainerLogic person in trainers)
            {
                if (person.Surname == su && person.Name == na && person.Age == ag)
                {
                    temp.Append(person.PrintTrainerInfo());
                    break;
                }
            }
            if (temp.ToString()=="")
            {
                temp.Append("Такого тренера нет!");
            }
            return temp.ToString();
        }
        public   void DeleteTrainer(string na, string su, int ag)
        {
            foreach (ITrainerLogic person in trainers)
            {
                if (person.Surname == su && person.Name == na && person.Age == ag)
                {
                    trainers.Remove(person);
                    break;
                }
            }
        }
        public  string PrintAllTrainers()
        {
            StringBuilder temp = new StringBuilder();
            foreach (ITrainerLogic person in trainers)
            {
                temp.Append(person.PrintTrainerInfo());
            }
            return temp.ToString();
        }
        public   string PrintTrainerSchedule(int id, int year, int month, int day)
        {
            StringBuilder tzmp = new StringBuilder();
            List<ILessonsLogic> temp = schedule.FindAll(x => x.Date.Year == year && x.Date.Month == month && x.Date.Day == day && x.Trainer.Id == id);
            foreach (ILessonsLogic tmp in temp)
            {
                tzmp.Append(tmp.PrintLesson());
            }
            return tzmp.ToString();
        }
        public   string PrintTrainerSchedule(int id, int year, int month)
        {
            StringBuilder tzmp = new StringBuilder();
            List<ILessonsLogic> temp = schedule.FindAll(x => x.Date.Year == year && x.Date.Month == month && x.Trainer.Id == id);
            foreach (ILessonsLogic tmp in temp)
            {
                tzmp.Append(tmp.PrintLesson());
            }
            return tzmp.ToString();
        }
        /////////////
        ///////////// HALL PART
        public   void AddHall(string na)
        {
            IHallLogic ha = new Hall();
            ha = ha.CreateHall(na);
            this.halls.Add(ha);
        }
        public   string FindHall(string su)
        {
            StringBuilder temp = new StringBuilder();
            foreach (IHallLogic ha in halls)
            {
                if (ha.Name == su)
                {
                    temp.Append(ha.PrintHallInfo());
                    break;
                }
            }
            if (temp.ToString()=="")
            {
                temp.Append("Такого клиента нет!");
            }
            return temp.ToString();
        }
        public   void DeleteHall(string na)
        {
            foreach (IHallLogic ls in halls)
            {
                if (ls.Name == na)
                {
                    halls.Remove(ls);
                    break;
                }
            }
        }
        public   string PrintAllHalls()
        {
            StringBuilder temp = new StringBuilder();
            foreach (IHallLogic ls in halls)
            {
                temp.Append(ls.PrintHallInfo());
            }
            return temp.ToString();
        }
        public   string PrintHallSchedule(int id, int year, int month, int day)
        {
            StringBuilder tzmp = new StringBuilder();
            List<ILessonsLogic> temp = schedule.FindAll(x => x.Date.Year == year && x.Date.Month == month && x.Date.Day == day && x.Hall.Id == id);
            foreach (ILessonsLogic tmp in temp)
            {
                tzmp.Append(tmp.PrintLesson());
            }
            return tzmp.ToString();
        }
        public   string PrintHallSchedule( int id, int year, int month)
        {
            StringBuilder tzmp = new StringBuilder();
            List<ILessonsLogic> temp = schedule.FindAll(x => x.Date.Year == year && x.Date.Month == month && x.Hall.Id == id);
            foreach (ILessonsLogic tmp in temp)
            {
                tzmp.Append(tmp.PrintLesson());
            }
            return tzmp.ToString();
        }
        /////////////
        /////////////SCHEDULE PART
        public   string ShowSchedule()
        {
            StringBuilder tzmp = new StringBuilder();
            foreach (ILessonsLogic ls in schedule)
            {
                tzmp.Append(ls.PrintLesson());
            }
            return tzmp.ToString();
        }
        /////////////
        public   List<ILessonsLogic> Schedule
        {
            get { return schedule; }
            set { schedule = value; }
        }
        public   List<ICustomerLogic> Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        public   List<IHallLogic> Halls
        {
            get { return halls; }
            set { halls = value; }
        }
        public   List<ITrainerLogic> Trainers
        {
            get { return trainers; }
            set { trainers = value; }
        }
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public string Fl
        {
            get { return fl; }
            set { fl= value; }
        }
        public void AddTrainerForLesson(int id,string name,string surname,int age,string work)
        {
            ITrainerLogic tr = new Trainer();
            tr = tr.CreateTrainer(id, name, surname, age, work);
            this.cash_trainer = tr;
        }
        public void AddHallForLesson(int id, string name)
        {
            IHallLogic ha = new Hall();
            ha= ha.CreateHall(id, name);
            this.cash_hall = ha;
        }
        public void AddCustomersForLesson(int id, string name, string surname, int age)
        {
            ICustomerLogic cu = new Customer();
            cu = cu.CreateCustomer(id, name,surname,age);
            this.cash_customers.Add(cu);
        }
        public void CreateLesson(int year,int month,int day,int hour,int minute)
        {
            IDateLogic dt = new Date();
            dt=dt.CreateDate(year,month,day,hour,minute);   
            ILessonsLogic temp=new Lessons();
            temp= temp.CreateLesson(this,dt,this.cash_hall,this.cash_trainer,this.cash_customers);
            cash_hall = new Hall();
            cash_trainer = new Trainer();
            cash_customers = new List<ICustomerLogic>();
        }
        public IBaseLogic CreateBase()
        {
            IBaseLogic tmp = new Base();
            return tmp;
        }
        public void UnloadCustomers()
        {
            uncus.UnloadCustomersToFile(this.PrintAllCustomers(), this.path);
        }
        public void UnloadTrainers()
        {
            untr.UnloadTrainersToFile(this.PrintAllTrainers(), this.path);
        }
        public void UnloadHalls()
        {
            unha.UnloadHallsToFile(this.PrintAllHalls(), this.path);
        }
        public void UnloadSchedule()
        {
            unsched.UnloadScheduleToFile(this.ShowSchedule(), this.path);
        }
        public void UnloadSchedule(string text)
        {
            unsched.UnloadScheduleToFile(text , this.path);
        }
        public void UploadCustomers()
        {
            string[] chars = { " ", "\n" };
            string []mas = upcus.UploadCustomersToFile(this.path).Split(chars, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < mas.Length; i += 4)
            {
                ICustomerLogic temp = new Customer();
                temp = temp.UploadCustomer(int.Parse(mas[i]), mas[i + 1], mas[i + 2], int.Parse(mas[i + 3]));
                this.customers.Add(temp);
            }
        }
        public void UploadTrainers()
        {
            string[] chars = { " ", "\n" };
            string[] mas = uptr.UploadTrainersToFile(this.path).Split(chars, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < mas.Length; i += 5)
            {
                ITrainerLogic temp = new Trainer();
                temp = temp.UploadTrainer(int.Parse(mas[i]), mas[i + 1], mas[i + 2], int.Parse(mas[i + 3]), mas[i+4]);
                this.trainers.Add(temp);
            }
        }
        public void UploadHalls()
        {
            string[] chars = { " ", "\n" };
            string[] mas = upha.UploadHallsToFile(this.path).Split(chars, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < mas.Length; i += 2)
            {
                IHallLogic temp = new Hall();
                temp = temp.UploadHall(int.Parse(mas[i]), mas[i + 1]);
                this.halls.Add(temp);
            }
        }
        public void UploadSchedule()
        {
            string[] chars = { " ", "\n", ":", ".","\r" };
            string[] mas = upsched.UploadScheduleToFile(this.path).Split(chars, StringSplitOptions.RemoveEmptyEntries);
            int i = 0;
            while (i < mas.Length)
            {
                IDateLogic dt = new Date();
                dt = dt.CreateDate(int.Parse(mas[i]), int.Parse(mas[i + 1]), int.Parse(mas[i + 2]), int.Parse(mas[i + 3]), int.Parse(mas[i + 4]));
                ITrainerLogic tr = new Trainer();
                tr.Id= int.Parse(mas[i+5]);
                tr.Name = mas[i + 6];
                tr.Surname = mas[i + 7];
                tr.Age = int.Parse(mas[i + 8]);
                tr.Work = mas[i + 9];
                IHallLogic ha = new Hall();
                ha.Id= int.Parse(mas[i+10]);
                ha.Name= mas[i + 11];
                i += 12;
                List< ICustomerLogic > temp = new List< ICustomerLogic >();
                while (mas[i] != "_")
                {
                    ICustomerLogic cu = new Customer();
                    cu.Id = int.Parse(mas[i]);
                    cu.Name = mas[i + 1];
                    cu.Surname= mas[i + 2];
                    cu.Age = int.Parse(mas[i+3]);
                    temp.Add( cu );
                    i +=4;
                }
                i++;
                ILessonsLogic ls = new Lessons();
                ls = ls.CreateLesson(this, dt, ha, tr, temp);
            };
        }
    }
}

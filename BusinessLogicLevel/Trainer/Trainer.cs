using System;
using System.Collections.Generic;


namespace BusinessLogicLevel
{
    public class Trainer:ITrainerLogic
    {
        private string name;
        private string surname;
        private int age;
        private string work;
        private int id;
        private static int idi = 0;
        public Trainer()
        {
        }
        private Trainer(string name, string surname, int age, string work)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.work = work;
            idi++;
            this.id = idi;
        }
        private Trainer(int id, string name, string surname, int age,string work)
        {
            idi = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.id = id;
            this.work = work;
        }
        private static Trainer AddTrainer(int id, string name, string surname, int age,string work)
        {
            Trainer temp = new Trainer();
            temp.Id = id;
            temp.Name = name;
            temp.Surname = surname;
            temp.Age = age;
            temp.Work = work;
            return temp;
        }
        public ITrainerLogic CreateTrainer(int id, string name, string surname, int age,string work)
        {
            ITrainerLogic tmp = AddTrainer(id, name, surname, age,work);
            return tmp;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Work
        {
            get { return work; }
            set { work = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string PrintTrainerInfo()
        {
            return id.ToString()+"   "+ name.ToString() + "   " + surname.ToString() + "   " + age.ToString() + "   " + work.ToString()+"\n";
        }
        public ITrainerLogic CreateTrainer(string name, string surname, int age, string work)
        {
            ITrainerLogic temp = new Trainer(name, surname, age, work);
            return temp;
        }
        public ITrainerLogic UploadTrainer(int id, string name, string surname, int age, string work)
        {
            ITrainerLogic tmp = new Trainer(id, name, surname, age,work);
            return tmp;
        }
    }
}

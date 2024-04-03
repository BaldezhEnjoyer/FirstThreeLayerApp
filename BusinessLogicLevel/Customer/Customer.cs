using System;
using System.Collections.Generic;

namespace BusinessLogicLevel
{
    public class Customer:ICustomerLogic
    {
        private string name;
        private string surname;
        private int age;
        private int id ;
        private static int idi = 0;
        public Customer()
        {
        }
        private Customer(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            idi++;
            this.id = idi;
        }
        private Customer(int id,string name, string surname, int age)
        {
            idi= id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.id = id;
        }
        private static Customer AddCustomer(int id, string name, string surname, int age)
        {
            Customer temp = new Customer();
            temp.Id = id;
            temp.Name = name;
            temp.Surname = surname;
            temp.Age = age;
            return temp;
        }
        public ICustomerLogic CreateCustomer(int id, string name, string surname, int age)
        {
            ICustomerLogic tmp = AddCustomer(id, name, surname, age);
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
        public string PrintCustomerInfo()
        {
            return id.ToString() + "   " + name.ToString() + "   " + surname.ToString() + "   " + age.ToString() + "\n";
        }
        public ICustomerLogic CreateCustomer(string name, string surname, int age)
        {
            ICustomerLogic tmp = new Customer(name, surname, age);
            return tmp;
        }

        public ICustomerLogic UploadCustomer(int id,string name, string surname, int age)
        {
            ICustomerLogic tmp = new Customer(id,name, surname, age);
            return tmp;
        }
    }
}
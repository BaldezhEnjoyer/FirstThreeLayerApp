using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLogicLevel
{
    public interface ICustomerLogic
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
        string PrintCustomerInfo();
        ICustomerLogic CreateCustomer(string name, string surname, int age);
        ICustomerLogic CreateCustomer(int id,string name, string surname, int age);
        ICustomerLogic UploadCustomer(int id, string name, string surname, int age);
    }
}

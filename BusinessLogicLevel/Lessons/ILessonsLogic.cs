using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel
{
    public interface ILessonsLogic
    {
        IDateLogic Date
        {
            get;
            set;
        }
        ITrainerLogic Trainer
        {
            get;
            set;
        }
        List<ICustomerLogic> Customers
        {
            get;
            set;
        }
        IHallLogic Hall
        {
            get;
            set;
        }
        ILessonsLogic CreateLesson(IBaseLogic ba, IDateLogic dt, IHallLogic ha, ITrainerLogic tr, List<ICustomerLogic> cu);
        string PrintLesson();
    }
}

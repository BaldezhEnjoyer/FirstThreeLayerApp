using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLevel
{
    public interface IDateLogic
    {
        int Year
        {
            get;
            set;
        }
        int Month
        {
            get;
            set;
        }
        int Day
        {
            get;
            set;
        }
        int Hour
        {
            get;
            set;
        }
        int Minute
        {
            get;
            set;
        }
        string Print_date();
        IDateLogic CreateDate(int Year, int Month, int Day, int Hour, int Minute);
    }
}

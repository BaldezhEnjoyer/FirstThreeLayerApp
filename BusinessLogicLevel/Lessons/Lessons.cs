using System;
using System.Collections.Generic;
using System.Text;


namespace BusinessLogicLevel
{
    public class Lessons:ILessonsLogic
    {
        private IDateLogic date;
        private IHallLogic hall;
        private ITrainerLogic trainer;
        private List<ICustomerLogic> customers = new List<ICustomerLogic>();
        public Lessons()
        { }
        public Lessons(IBaseLogic ba, IDateLogic dt, IHallLogic ha, ITrainerLogic tr, List<ICustomerLogic> cu,int q)
        {
            Lessons temp = new Lessons();
            {
                temp.date = dt;
                temp.trainer = tr;
                temp.customers = cu;
                temp.hall = ha;
            }
            bool flag = false;
            CheckLesson(ba, temp, ref flag);
            if (flag == false)
            {
                this.date = dt;
                this.trainer = tr;
                this.customers = cu;
                this.hall = ha;
            }
        }
        private Lessons(IBaseLogic ba,IDateLogic dt, IHallLogic ha, ITrainerLogic tr, List<ICustomerLogic> cu)
        {
            if (ba.Schedule.Count == 0)
            {
                this.date = dt;
                this.trainer = tr;
                this.customers = cu;
                this.hall = ha;
                ba.Schedule.Add(this);
            }
            else
            {
                Lessons temp = new Lessons();
                {
                    temp.date = dt;
                    temp.trainer = tr;
                    temp.customers = cu;
                    temp.hall = ha;
                }
                bool flag = false;
                CheckLesson(ba,temp, ref flag);
                if (flag == false)
                {
                    this.date = dt;
                    this.trainer = tr;
                    this.customers = cu;
                    this.hall = ha;
                    ba.Schedule.Add(this);
                }
            }
        }
        private void CheckLesson(IBaseLogic ba,Lessons ls, ref bool flag)
        {
            foreach (Lessons l in ba.Schedule)
            {
                if (Math.Abs((l.Date.Hour * 60 + l.Date.Minute) - (ls.Date.Hour * 60 + ls.Date.Minute)) >= 60)
                {

                }
                else
                {
                    if (l.Hall.Id != ls.Hall.Id)
                    {
                        if (l.Trainer.Id != ls.Trainer.Id)
                        {
                            foreach (ICustomerLogic x1 in l.Customers)
                            {
                                if (ls.Customers.Contains(x1))
                                {
                                    flag = true;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }
                    else
                    {
                        flag = true;
                        break;
                    }
                }
            }
        }
        public string PrintLesson()
        {
            StringBuilder tmp= new StringBuilder() ;
            tmp.Append(this.Date.Print_date());
            tmp.Append(this.Trainer.PrintTrainerInfo());
            tmp.Append( this.Hall.PrintHallInfo());
            foreach (ICustomerLogic cu in this.Customers)
            {
                tmp.Append(cu.PrintCustomerInfo());
            }
            tmp.Append("_");
            tmp.Append( "\n");
            return tmp.ToString();
        }
        public IDateLogic Date
        {
            get { return date; }
            set { date = value; }
        }
        public ITrainerLogic Trainer
        {
            get { return trainer; }
            set { trainer = value; }
        }
        public List<ICustomerLogic> Customers
        {
            get { return customers; }
            set { customers = value; }
        }
        public IHallLogic Hall
        {
            get { return hall; }
            set { hall = value; }
        }
        public ILessonsLogic CreateLesson(IBaseLogic ba,IDateLogic dt, IHallLogic ha, ITrainerLogic tr, List<ICustomerLogic> cu)
        {
            ILessonsLogic temp = new Lessons(ba,dt, ha, tr, cu);
            return temp;
        }
    }
}


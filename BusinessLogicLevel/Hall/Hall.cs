using System;
using System.Collections.Generic;


namespace BusinessLogicLevel
{
    public class Hall:IHallLogic
    {
        private string name;
        private int id;
        private static int idi = 0;
        public Hall()
        {
        }
        private Hall(string name)
        {
            this.name = name;
            idi++;
            this.id = idi;
        }
        private Hall(int id, string name)
        {
            idi = id;
            this.name = name;
            this.id = id;
        }
        private static Hall AddHall(int id, string name)
        {
            Hall temp = new Hall();
            temp.Id = id;
            temp.Name = name;
            return temp;
        }
        public IHallLogic CreateHall(int id, string name)
        {
            IHallLogic tmp = AddHall(id, name);
            return tmp;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string PrintHallInfo()
        {
            return id.ToString() + "   " + name.ToString() + "\n";
        }
        public IHallLogic CreateHall(string name)
        {
            IHallLogic temp = new Hall(name);
            return temp;
        }
        public IHallLogic UploadHall(int id, string name)
        {
            IHallLogic tmp = new Hall(id, name);
            return tmp;
        }
    }
}

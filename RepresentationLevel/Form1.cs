using BusinessLogicLevel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RepresentationLevel
{
    public partial class Form1 : Form
    {
        private IBaseLogic basa = new Base();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            basa = basa.CreateBase();
        }

        private void CreateCustomersList_Click(object sender, EventArgs e)
        {
            try
            {
                if (basa.Customers.Count == 0)
                {
                    foreach (DataGridViewRow ro in dataGridView1.Rows)
                    {
                        if (ro.Cells[0].Value != null && ro.Cells[1].Value != null && ro.Cells[2].Value != null)
                        {
                            basa.AddCustomer(ro.Cells[0].Value.ToString(), ro.Cells[1].Value.ToString(), int.Parse(ro.Cells[2].Value.ToString()));
                            CustomersList.Items.Add(basa.Customers[basa.Customers.Count - 1].PrintCustomerInfo());
                        }
                    }
                }
                else
                {
                    basa.Customers = new List<ICustomerLogic>();
                    CustomersList.Items.Clear();
                    foreach (DataGridViewRow ro in dataGridView1.Rows)
                    {
                        if (ro.Cells[0].Value != null && ro.Cells[1].Value != null && ro.Cells[2].Value != null)
                        {
                            basa.AddCustomer(ro.Cells[0].Value.ToString(), ro.Cells[1].Value.ToString(), int.Parse(ro.Cells[2].Value.ToString()));
                            CustomersList.Items.Add(basa.Customers[basa.Customers.Count - 1].PrintCustomerInfo());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
        private void UploadCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.Rows.Clear();
                    basa.Customers = new List<ICustomerLogic>();
                    CustomersList.Items.Clear();
                    basa.Path = openFileDialog1.FileName;
                    basa.UploadCustomers();
                    foreach (ICustomerLogic cu in basa.Customers)
                    {
                        string[] temp = new string[3] { cu.Surname, cu.Name, cu.Age.ToString() };
                        dataGridView1.Rows.Add(temp);
                        CustomersList.Items.Add(cu.PrintCustomerInfo());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void UnloaderCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    basa.Path = saveFileDialog1.FileName;
                    basa.UnloadCustomers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void CustomersFinder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] temp = CustomersFinder.Text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (DataGridViewRow ro in dataGridView1.Rows)
                {
                    if (ro.Cells[0].Value != null && ro.Cells[1].Value != null && ro.Cells[2].Value != null)
                    {
                        if (temp.Length == 3)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0] && ro.Cells[1].Value.ToString() == temp[1] && ro.Cells[2].Value.ToString() == temp[2])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                        else if (temp.Length == 2)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0] && ro.Cells[1].Value.ToString() == temp[1])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                        else if (temp.Length == 1)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void UploadTrainers_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    dataGridView2.Rows.Clear();
                    basa.Trainers = new List<ITrainerLogic>();
                    TrainersList.Items.Clear();
                    basa.Path = openFileDialog2.FileName;
                    basa.UploadTrainers();
                    foreach (ITrainerLogic cu in basa.Trainers)
                    {
                        string[] temp = new string[4] { cu.Surname, cu.Name, cu.Age.ToString(), cu.Work };
                        dataGridView2.Rows.Add(temp);
                        TrainersList.Items.Add(cu.PrintTrainerInfo());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void UnloadTrainers_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog2.ShowDialog() == DialogResult.OK)
                {
                    basa.Path = saveFileDialog2.FileName;
                    basa.UnloadTrainers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void CreateTrainersList_Click(object sender, EventArgs e)
        {
            try
            {
                if (basa.Trainers.Count == 0)
                {
                    foreach (DataGridViewRow ro in dataGridView2.Rows)
                    {
                        if (ro.Cells[0].Value != null && ro.Cells[1].Value != null && ro.Cells[2].Value != null && ro.Cells[3].Value != null)
                        {
                            basa.AddTrainer(ro.Cells[0].Value.ToString(), ro.Cells[1].Value.ToString(), int.Parse(ro.Cells[2].Value.ToString()), ro.Cells[3].Value.ToString());
                            TrainersList.Items.Add(basa.Trainers[basa.Trainers.Count - 1].PrintTrainerInfo());
                        }
                    }
                }
                else
                {
                    TrainersList.Items.Clear();
                    basa.Trainers = new List<ITrainerLogic>();
                    foreach (DataGridViewRow ro in dataGridView2.Rows)
                    {
                        if (ro.Cells[0].Value != null && ro.Cells[1].Value != null && ro.Cells[2].Value != null && ro.Cells[3].Value != null)
                        {
                            basa.AddTrainer(ro.Cells[0].Value.ToString(), ro.Cells[1].Value.ToString(), int.Parse(ro.Cells[2].Value.ToString()), ro.Cells[3].Value.ToString());
                            TrainersList.Items.Add(basa.Trainers[basa.Trainers.Count - 1].PrintTrainerInfo());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void TrainersFinder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] temp = TrainersFinder.Text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (DataGridViewRow ro in dataGridView2.Rows)
                {
                    if (ro.Cells[0].Value != null && ro.Cells[1].Value != null && ro.Cells[2].Value != null && ro.Cells[3].Value != null)
                    {
                        if (temp.Length == 4)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0] && ro.Cells[1].Value.ToString() == temp[1] && ro.Cells[2].Value.ToString() == temp[2] && ro.Cells[3].Value.ToString() == temp[3])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                        else if (temp.Length == 3)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0] && ro.Cells[1].Value.ToString() == temp[1] && ro.Cells[2].Value.ToString() == temp[2])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                        else if (temp.Length == 2)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0] && ro.Cells[1].Value.ToString() == temp[1])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                        else if (temp.Length == 1)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void CreateHallsList_Click(object sender, EventArgs e)
        {
            try
            {
                if (basa.Halls.Count == 0)
                {
                    foreach (DataGridViewRow ro in dataGridView3.Rows)
                    {
                        if (ro.Cells[0].Value != null)
                        {
                            basa.AddHall(ro.Cells[0].Value.ToString());
                            HallsList.Items.Add(basa.Halls[basa.Halls.Count - 1].PrintHallInfo());
                        }
                    }
                }
                else
                {
                    HallsList.Items.Clear();
                    basa.Halls = new List<IHallLogic>();
                    foreach (DataGridViewRow ro in dataGridView3.Rows)
                    {
                        if (ro.Cells[0].Value != null)
                        {
                            basa.AddHall(ro.Cells[0].Value.ToString());
                            HallsList.Items.Add(basa.Halls[basa.Halls.Count - 1].PrintHallInfo());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void HallsFinder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string[] temp = HallsFinder.Text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (DataGridViewRow ro in dataGridView3.Rows)
                {
                    if (ro.Cells[0].Value != null)
                    {
                        if (temp.Length == 1)
                        {
                            if (ro.Cells[0].Value.ToString() == temp[0])
                            {
                                ro.Selected = true;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void UploadHalls_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog3.ShowDialog() == DialogResult.OK)
                {
                    dataGridView3.Rows.Clear();
                    basa.Halls = new List<IHallLogic>();
                    HallsList.Items.Clear();
                    basa.Path = openFileDialog3.FileName;
                    basa.UploadHalls();
                    foreach (IHallLogic cu in basa.Halls)
                    {
                        string[] temp = new string[1] { cu.Name };
                        dataGridView3.Rows.Add(temp);
                        HallsList.Items.Add(cu.PrintHallInfo());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog3.ShowDialog() == DialogResult.OK)
                {
                    basa.Path = saveFileDialog3.FileName;
                    basa.UnloadHalls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void TryCreateLesson_Click(object sender, EventArgs e)
        {
            try
            {
                string[] temp = textBox1.Text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries).Concat(textBox2.Text.Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries)).ToArray();
                foreach (object obj in comboBox1.Items)
                {
                    string[] temp2 = obj.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    basa.AddTrainerForLesson(int.Parse(temp2[0]), temp[1], temp2[2], int.Parse(temp[3]), temp[4]);
                }
                foreach (object obj in comboBox2.Items)
                {
                    string[] temp2 = obj.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    basa.AddHallForLesson(int.Parse(temp2[0]), temp[1]);
                }
                foreach (object obj in comboBox3.Items)
                {
                    string[] temp2 = obj.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                    basa.AddCustomersForLesson(int.Parse(temp2[0]), temp[1], temp2[2], int.Parse(temp[3]));
                }
                int k = basa.Schedule.Count;
                basa.CreateLesson(int.Parse(temp[2]), int.Parse(temp[1]), int.Parse(temp[0]), int.Parse(temp[3]), int.Parse(temp[4]));
                if (basa.Schedule.Count > k)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridView4.Rows[0].Clone();
                    row.Cells[0].Value = textBox1.Text;
                    row.Cells[1].Value = textBox2.Text;
                    row.Cells[2].Value = comboBox1.Items[0];
                    row.Cells[3].Value = comboBox2.Items[0];
                    DataGridViewComboBoxCell comboBoxCell = row.Cells[4] as DataGridViewComboBoxCell;
                    comboBoxCell.Items.Clear();
                    foreach (object obj in comboBox3.Items)
                    {
                        comboBoxCell.Items.Add(obj);
                    }
                    dataGridView4.Rows.Add(row);
                    comboBox1.Items.Clear();
                    comboBox2.Items.Clear();
                    comboBox3.Items.Clear();
                    textBox1.Text = "";
                    textBox2.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заполнены не все поля");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(TrainersList.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(HallsList.SelectedItem);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox3.Items.Add(CustomersList.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                basa.Schedule = new List<ILessonsLogic>();
                foreach (DataGridViewRow ro in dataGridView4.Rows)
                {
                    if (ro.Cells[0].Value != null)
                    {
                        string[] temp = ro.Cells[0].Value.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                        string[] temp2 = ro.Cells[1].Value.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                        IDateLogic dt = new Date();
                        dt.Day = int.Parse(temp[0]);
                        dt.Month = int.Parse(temp[1]);
                        dt.Year = int.Parse(temp[2]);
                        dt.Hour = int.Parse(temp2[0]);
                        dt.Minute = int.Parse(temp2[1]);
                        temp = ro.Cells[2].Value.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                        ITrainerLogic tr = new Trainer();
                        tr.Id = int.Parse(temp[0]);
                        tr.Surname = temp[1];
                        tr.Name = temp[2];
                        tr.Age = int.Parse(temp[3]);
                        tr.Work = temp[4];
                        temp = ro.Cells[3].Value.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                        IHallLogic ha = new Hall();
                        ha.Id = int.Parse(temp[0]);
                        ha.Name = temp[1];
                        List<ICustomerLogic> cus = new List<ICustomerLogic>();
                        DataGridViewComboBoxCell comboBoxCell = ro.Cells[4] as DataGridViewComboBoxCell;
                        foreach (object obj in comboBoxCell.Items)
                        {
                            temp = obj.ToString().Split(new char[] { ' ', '.', ':' }, StringSplitOptions.RemoveEmptyEntries);
                            ICustomerLogic cu = new Customer();
                            cu.Id = int.Parse(temp[0]);
                            cu.Surname = temp[1];
                            cu.Name = temp[2];
                            cu.Age = int.Parse(temp[3]);
                            cus.Add(cu);
                        }
                        basa.Schedule.Add(new Lessons(basa, dt, ha, tr, cus, 0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void UnloadSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveFileDialog4.ShowDialog() == DialogResult.OK)
                {
                    basa.Path = saveFileDialog4.FileName;
                    basa.UnloadSchedule();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void UploadSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog4.ShowDialog() == DialogResult.OK)
                {
                    dataGridView4.Rows.Clear();
                    basa.Schedule = new List<ILessonsLogic>();
                    basa.Path = openFileDialog4.FileName;
                    basa.UploadSchedule();
                    foreach (ILessonsLogic cu in basa.Schedule)
                    {
                        DataGridViewRow ro = (DataGridViewRow)dataGridView4.Rows[0].Clone();
                        ro.Cells[0].Value = cu.Date.Day.ToString() + "." + cu.Date.Month.ToString() + "." + cu.Date.Year.ToString();
                        ro.Cells[1].Value = cu.Date.Hour.ToString() + ":" + cu.Date.Minute.ToString();
                        ro.Cells[2].Value = cu.Trainer.PrintTrainerInfo();
                        ro.Cells[3].Value = cu.Hall.PrintHallInfo();
                        DataGridViewComboBoxCell comboBoxCell = ro.Cells[4] as DataGridViewComboBoxCell;
                        comboBoxCell.Items.Clear();
                        foreach (ICustomerLogic cus in cu.Customers)
                        {
                            comboBoxCell.Items.Add(cus.PrintCustomerInfo());
                        }
                        dataGridView4.Rows.Add(ro);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow ro in dataGridView4.Rows)
                {
                    if (ro.Cells[0].Value != null)
                    {
                        if (ro.Cells[2].Value.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] == textBox7.Text)
                        {
                            ro.Selected = true;
                        }
                        else
                        {
                            ro.Selected = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow ro in dataGridView4.Rows)
                {
                    if (ro.Cells[0].Value != null)
                    {
                        if (ro.Cells[0].Value.ToString() == textBox4.Text)
                        {
                            ro.Selected = true;
                        }
                        else
                        {
                            ro.Selected = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow ro in dataGridView4.Rows)
                {
                    if (ro.Cells[0].Value != null)
                    {
                        DataGridViewComboBoxCell comboBoxCell = ro.Cells[4] as DataGridViewComboBoxCell;
                        foreach(object obj in comboBoxCell.Items)
                        {
                            if (obj.ToString().Split(' ')[0] == textBox3.Text)
                            {
                                ro.Selected = true;
                                break;
                            }
                            else
                            {
                                ro.Selected = false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow ro in dataGridView4.Rows)
                {
                    if (ro.Cells[0].Value != null)
                    {
                        if (ro.Cells[3].Value.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0] == textBox6.Text)
                        {
                            ro.Selected = true;
                        }
                        else
                        {
                            ro.Selected = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow ro in dataGridView4.Rows)
                {
                    if (ro.Cells[0].Value != null)
                    {
                        if (ro.Cells[1].Value.ToString() == textBox5.Text)
                        {
                            ro.Selected = true;
                        }
                        else
                        {
                            ro.Selected = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
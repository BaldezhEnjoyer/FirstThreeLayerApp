using BusinessLogicLevel;
namespace RepresentationLevel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            CustomersPage = new TabPage();
            label1 = new Label();
            CreateCustomersList = new Button();
            UnloaderCustomers = new Button();
            UploadCustomers = new Button();
            CustomersFinder = new TextBox();
            dataGridView1 = new DataGridView();
            Surname_с = new DataGridViewTextBoxColumn();
            Name_с = new DataGridViewTextBoxColumn();
            Age_с = new DataGridViewTextBoxColumn();
            TrainersPage = new TabPage();
            TrainersFinder = new TextBox();
            dataGridView2 = new DataGridView();
            Name_t = new DataGridViewTextBoxColumn();
            Surname = new DataGridViewTextBoxColumn();
            Age_t = new DataGridViewTextBoxColumn();
            Work_t = new DataGridViewTextBoxColumn();
            label2 = new Label();
            UnloadTrainers = new Button();
            UploadTrainers = new Button();
            CreateTrainersList = new Button();
            HallsPage = new TabPage();
            HallsFinder = new TextBox();
            button3 = new Button();
            UploadHalls = new Button();
            CreateHallsList = new Button();
            label3 = new Label();
            dataGridView3 = new DataGridView();
            Name_h = new DataGridViewTextBoxColumn();
            SchedulePage = new TabPage();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label4 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            button7 = new Button();
            button6 = new Button();
            button1 = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            UnloadSchedule = new Button();
            UploadSchedule = new Button();
            button2 = new Button();
            TryCreateLesson = new Button();
            textBox2 = new TextBox();
            dataGridView4 = new DataGridView();
            DateSchedule = new DataGridViewTextBoxColumn();
            TimeSchedule = new DataGridViewTextBoxColumn();
            ScheduleTrainer = new DataGridViewTextBoxColumn();
            HallSchedule = new DataGridViewTextBoxColumn();
            CustomersSchedule = new DataGridViewComboBoxColumn();
            textBox1 = new TextBox();
            HallsList = new ComboBox();
            TrainersList = new ComboBox();
            CustomersList = new ComboBox();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            openFileDialog2 = new OpenFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            openFileDialog3 = new OpenFileDialog();
            saveFileDialog3 = new SaveFileDialog();
            openFileDialog4 = new OpenFileDialog();
            saveFileDialog4 = new SaveFileDialog();
            tabControl1.SuspendLayout();
            CustomersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TrainersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            HallsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SchedulePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CustomersPage);
            tabControl1.Controls.Add(TrainersPage);
            tabControl1.Controls.Add(HallsPage);
            tabControl1.Controls.Add(SchedulePage);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(825, 650);
            tabControl1.TabIndex = 0;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(label1);
            CustomersPage.Controls.Add(CreateCustomersList);
            CustomersPage.Controls.Add(UnloaderCustomers);
            CustomersPage.Controls.Add(UploadCustomers);
            CustomersPage.Controls.Add(CustomersFinder);
            CustomersPage.Controls.Add(dataGridView1);
            CustomersPage.Location = new Point(4, 24);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(817, 622);
            CustomersPage.TabIndex = 0;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(340, 40);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 7;
            label1.Text = "Поиск";
            // 
            // CreateCustomersList
            // 
            CreateCustomersList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateCustomersList.Location = new Point(8, 60);
            CreateCustomersList.Name = "CreateCustomersList";
            CreateCustomersList.Size = new Size(216, 36);
            CreateCustomersList.TabIndex = 6;
            CreateCustomersList.Text = "Обновить список клиентов";
            CreateCustomersList.UseVisualStyleBackColor = true;
            CreateCustomersList.Click += CreateCustomersList_Click;
            // 
            // UnloaderCustomers
            // 
            UnloaderCustomers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UnloaderCustomers.Location = new Point(636, 38);
            UnloaderCustomers.Name = "UnloaderCustomers";
            UnloaderCustomers.Size = new Size(172, 27);
            UnloaderCustomers.TabIndex = 5;
            UnloaderCustomers.Text = "Выгрузить список клиентов";
            UnloaderCustomers.UseVisualStyleBackColor = true;
            UnloaderCustomers.Click += UnloaderCustomers_Click;
            // 
            // UploadCustomers
            // 
            UploadCustomers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UploadCustomers.Location = new Point(644, 6);
            UploadCustomers.Name = "UploadCustomers";
            UploadCustomers.Size = new Size(165, 27);
            UploadCustomers.TabIndex = 4;
            UploadCustomers.Text = "Загрузить список клиентов";
            UploadCustomers.UseVisualStyleBackColor = true;
            UploadCustomers.Click += UploadCustomers_Click;
            // 
            // CustomersFinder
            // 
            CustomersFinder.Location = new Point(240, 73);
            CustomersFinder.Name = "CustomersFinder";
            CustomersFinder.Size = new Size(269, 23);
            CustomersFinder.TabIndex = 3;
            CustomersFinder.TextChanged += CustomersFinder_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Surname_с, Name_с, Age_с });
            dataGridView1.Location = new Point(8, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(501, 512);
            dataGridView1.TabIndex = 0;
            // 
            // Surname_с
            // 
            Surname_с.HeaderText = "Фамилия";
            Surname_с.Name = "Surname_с";
            Surname_с.Width = 200;
            // 
            // Name_с
            // 
            Name_с.HeaderText = "Имя";
            Name_с.Name = "Name_с";
            Name_с.Width = 150;
            // 
            // Age_с
            // 
            Age_с.HeaderText = "Возраст";
            Age_с.Name = "Age_с";
            // 
            // TrainersPage
            // 
            TrainersPage.Controls.Add(TrainersFinder);
            TrainersPage.Controls.Add(dataGridView2);
            TrainersPage.Controls.Add(label2);
            TrainersPage.Controls.Add(UnloadTrainers);
            TrainersPage.Controls.Add(UploadTrainers);
            TrainersPage.Controls.Add(CreateTrainersList);
            TrainersPage.Location = new Point(4, 24);
            TrainersPage.Name = "TrainersPage";
            TrainersPage.Padding = new Padding(3);
            TrainersPage.Size = new Size(817, 622);
            TrainersPage.TabIndex = 1;
            TrainersPage.Text = "Trainers";
            TrainersPage.UseVisualStyleBackColor = true;
            // 
            // TrainersFinder
            // 
            TrainersFinder.Location = new Point(240, 73);
            TrainersFinder.Name = "TrainersFinder";
            TrainersFinder.Size = new Size(269, 23);
            TrainersFinder.TabIndex = 5;
            TrainersFinder.TextChanged += TrainersFinder_TextChanged;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Name_t, Surname, Age_t, Work_t });
            dataGridView2.Location = new Point(8, 102);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(501, 512);
            dataGridView2.TabIndex = 4;
            // 
            // Name_t
            // 
            Name_t.HeaderText = "Имя";
            Name_t.Name = "Name_t";
            Name_t.Width = 200;
            // 
            // Surname
            // 
            Surname.HeaderText = "Фамилия";
            Surname.Name = "Surname";
            // 
            // Age_t
            // 
            Age_t.HeaderText = "Возраст";
            Age_t.Name = "Age_t";
            Age_t.Width = 60;
            // 
            // Work_t
            // 
            Work_t.HeaderText = "Работа";
            Work_t.Name = "Work_t";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(340, 40);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 3;
            label2.Text = "Поиск";
            // 
            // UnloadTrainers
            // 
            UnloadTrainers.Location = new Point(636, 38);
            UnloadTrainers.Name = "UnloadTrainers";
            UnloadTrainers.Size = new Size(172, 27);
            UnloadTrainers.TabIndex = 2;
            UnloadTrainers.Text = "Выгрузить список тренеров";
            UnloadTrainers.UseVisualStyleBackColor = true;
            UnloadTrainers.Click += UnloadTrainers_Click;
            // 
            // UploadTrainers
            // 
            UploadTrainers.Location = new Point(644, 6);
            UploadTrainers.Name = "UploadTrainers";
            UploadTrainers.Size = new Size(165, 27);
            UploadTrainers.TabIndex = 1;
            UploadTrainers.Text = "Загрузить список тренеров";
            UploadTrainers.UseVisualStyleBackColor = true;
            UploadTrainers.Click += UploadTrainers_Click;
            // 
            // CreateTrainersList
            // 
            CreateTrainersList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateTrainersList.Location = new Point(8, 60);
            CreateTrainersList.Name = "CreateTrainersList";
            CreateTrainersList.Size = new Size(216, 36);
            CreateTrainersList.TabIndex = 0;
            CreateTrainersList.Text = "Обновить список тренеров";
            CreateTrainersList.UseVisualStyleBackColor = true;
            CreateTrainersList.Click += CreateTrainersList_Click;
            // 
            // HallsPage
            // 
            HallsPage.Controls.Add(HallsFinder);
            HallsPage.Controls.Add(button3);
            HallsPage.Controls.Add(UploadHalls);
            HallsPage.Controls.Add(CreateHallsList);
            HallsPage.Controls.Add(label3);
            HallsPage.Controls.Add(dataGridView3);
            HallsPage.Location = new Point(4, 24);
            HallsPage.Name = "HallsPage";
            HallsPage.Size = new Size(817, 622);
            HallsPage.TabIndex = 2;
            HallsPage.Text = "Halls";
            HallsPage.UseVisualStyleBackColor = true;
            // 
            // HallsFinder
            // 
            HallsFinder.Location = new Point(240, 73);
            HallsFinder.Name = "HallsFinder";
            HallsFinder.Size = new Size(269, 23);
            HallsFinder.TabIndex = 5;
            HallsFinder.TextChanged += HallsFinder_TextChanged;
            // 
            // button3
            // 
            button3.Location = new Point(636, 38);
            button3.Name = "button3";
            button3.Size = new Size(172, 27);
            button3.TabIndex = 4;
            button3.Text = "Выгрузить список залов";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UploadHalls
            // 
            UploadHalls.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            UploadHalls.Location = new Point(644, 6);
            UploadHalls.Name = "UploadHalls";
            UploadHalls.Size = new Size(165, 27);
            UploadHalls.TabIndex = 3;
            UploadHalls.Text = "Загрузить список залов";
            UploadHalls.UseVisualStyleBackColor = true;
            UploadHalls.Click += UploadHalls_Click;
            // 
            // CreateHallsList
            // 
            CreateHallsList.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CreateHallsList.Location = new Point(8, 60);
            CreateHallsList.Name = "CreateHallsList";
            CreateHallsList.Size = new Size(216, 36);
            CreateHallsList.TabIndex = 2;
            CreateHallsList.Text = "Обновить список залов";
            CreateHallsList.UseVisualStyleBackColor = true;
            CreateHallsList.Click += CreateHallsList_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(340, 40);
            label3.Name = "label3";
            label3.Size = new Size(54, 21);
            label3.TabIndex = 1;
            label3.Text = "Поиск";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { Name_h });
            dataGridView3.Location = new Point(8, 102);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(501, 512);
            dataGridView3.TabIndex = 0;
            // 
            // Name_h
            // 
            Name_h.HeaderText = "Название";
            Name_h.Name = "Name_h";
            Name_h.Width = 400;
            // 
            // SchedulePage
            // 
            SchedulePage.Controls.Add(textBox7);
            SchedulePage.Controls.Add(textBox6);
            SchedulePage.Controls.Add(textBox5);
            SchedulePage.Controls.Add(textBox4);
            SchedulePage.Controls.Add(textBox3);
            SchedulePage.Controls.Add(label16);
            SchedulePage.Controls.Add(label15);
            SchedulePage.Controls.Add(label14);
            SchedulePage.Controls.Add(label13);
            SchedulePage.Controls.Add(label4);
            SchedulePage.Controls.Add(label12);
            SchedulePage.Controls.Add(label11);
            SchedulePage.Controls.Add(label10);
            SchedulePage.Controls.Add(comboBox3);
            SchedulePage.Controls.Add(comboBox2);
            SchedulePage.Controls.Add(comboBox1);
            SchedulePage.Controls.Add(button7);
            SchedulePage.Controls.Add(button6);
            SchedulePage.Controls.Add(button1);
            SchedulePage.Controls.Add(label9);
            SchedulePage.Controls.Add(label8);
            SchedulePage.Controls.Add(label7);
            SchedulePage.Controls.Add(label6);
            SchedulePage.Controls.Add(label5);
            SchedulePage.Controls.Add(UnloadSchedule);
            SchedulePage.Controls.Add(UploadSchedule);
            SchedulePage.Controls.Add(button2);
            SchedulePage.Controls.Add(TryCreateLesson);
            SchedulePage.Controls.Add(textBox2);
            SchedulePage.Controls.Add(dataGridView4);
            SchedulePage.Controls.Add(textBox1);
            SchedulePage.Controls.Add(HallsList);
            SchedulePage.Controls.Add(TrainersList);
            SchedulePage.Controls.Add(CustomersList);
            SchedulePage.Location = new Point(4, 24);
            SchedulePage.Name = "SchedulePage";
            SchedulePage.Size = new Size(817, 622);
            SchedulePage.TabIndex = 3;
            SchedulePage.Text = "Schedule";
            SchedulePage.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(331, 285);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(135, 23);
            textBox7.TabIndex = 35;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(472, 285);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(86, 23);
            textBox6.TabIndex = 34;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(215, 285);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(110, 23);
            textBox5.TabIndex = 33;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 285);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(85, 23);
            textBox4.TabIndex = 32;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(564, 285);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(142, 23);
            textBox3.TabIndex = 31;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(575, 267);
            label16.Name = "label16";
            label16.Size = new Size(115, 15);
            label16.TabIndex = 30;
            label16.Text = "Поиск по клиентам";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(472, 267);
            label15.Name = "label15";
            label15.Size = new Size(86, 15);
            label15.TabIndex = 29;
            label15.Text = "Поиск по залу";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(348, 267);
            label14.Name = "label14";
            label14.Size = new Size(106, 15);
            label14.TabIndex = 28;
            label14.Text = "Поиск по тренеру";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(215, 267);
            label13.Name = "label13";
            label13.Size = new Size(110, 15);
            label13.TabIndex = 27;
            label13.Text = "Поиск по времени";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(124, 267);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 26;
            label4.Text = "Поиск по дате";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(666, 212);
            label12.Name = "label12";
            label12.Size = new Size(55, 15);
            label12.TabIndex = 25;
            label12.Text = "Клиенты";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(591, 212);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 24;
            label11.Text = "Зал";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(442, 212);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 23;
            label10.Text = "Тренер";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(666, 230);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(143, 23);
            comboBox3.TabIndex = 22;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(554, 230);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(106, 23);
            comboBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(376, 230);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 23);
            comboBox1.TabIndex = 20;
            // 
            // button7
            // 
            button7.Location = new Point(370, 74);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 19;
            button7.Text = "Выбрать";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(215, 74);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 18;
            button6.Text = "Выбрать";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.Location = new Point(51, 74);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Выбрать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(323, 27);
            label9.Name = "label9";
            label9.Size = new Size(165, 15);
            label9.TabIndex = 16;
            label9.Text = "Выбор клиентов для занятия";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(179, 27);
            label8.Name = "label8";
            label8.Size = new Size(138, 15);
            label8.TabIndex = 15;
            label8.Text = "Выбор зала для занятия";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 27);
            label7.Name = "label7";
            label7.Size = new Size(165, 15);
            label7.TabIndex = 14;
            label7.Text = "Выбор тренеров для занятия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 212);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 13;
            label6.Text = "Время";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(215, 212);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 12;
            label5.Text = "Дата";
            // 
            // UnloadSchedule
            // 
            UnloadSchedule.Location = new Point(636, 38);
            UnloadSchedule.Name = "UnloadSchedule";
            UnloadSchedule.Size = new Size(172, 27);
            UnloadSchedule.TabIndex = 11;
            UnloadSchedule.Text = "Выгрузить расписание";
            UnloadSchedule.UseVisualStyleBackColor = true;
            UnloadSchedule.Click += UnloadSchedule_Click;
            // 
            // UploadSchedule
            // 
            UploadSchedule.Location = new Point(644, 6);
            UploadSchedule.Name = "UploadSchedule";
            UploadSchedule.Size = new Size(165, 27);
            UploadSchedule.TabIndex = 10;
            UploadSchedule.Text = "Загрузить расписание";
            UploadSchedule.UseVisualStyleBackColor = true;
            UploadSchedule.Click += UploadSchedule_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(8, 280);
            button2.Name = "button2";
            button2.Size = new Size(90, 47);
            button2.TabIndex = 7;
            button2.Text = "Обновить расписание";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TryCreateLesson
            // 
            TryCreateLesson.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TryCreateLesson.Location = new Point(8, 205);
            TryCreateLesson.Name = "TryCreateLesson";
            TryCreateLesson.Size = new Size(175, 48);
            TryCreateLesson.TabIndex = 6;
            TryCreateLesson.Text = "Создать занятие";
            TryCreateLesson.UseVisualStyleBackColor = true;
            TryCreateLesson.Click += TryCreateLesson_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(279, 230);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(91, 23);
            textBox2.TabIndex = 5;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { DateSchedule, TimeSchedule, ScheduleTrainer, HallSchedule, CustomersSchedule });
            dataGridView4.Location = new Point(8, 333);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(801, 281);
            dataGridView4.TabIndex = 4;
            // 
            // DateSchedule
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            DateSchedule.DefaultCellStyle = dataGridViewCellStyle1;
            DateSchedule.HeaderText = "Дата";
            DateSchedule.Name = "DateSchedule";
            DateSchedule.Width = 75;
            // 
            // TimeSchedule
            // 
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            TimeSchedule.DefaultCellStyle = dataGridViewCellStyle2;
            TimeSchedule.HeaderText = "Время";
            TimeSchedule.Name = "TimeSchedule";
            TimeSchedule.Width = 60;
            // 
            // ScheduleTrainer
            // 
            ScheduleTrainer.HeaderText = "Тренер";
            ScheduleTrainer.Name = "ScheduleTrainer";
            ScheduleTrainer.Resizable = DataGridViewTriState.True;
            ScheduleTrainer.Width = 200;
            // 
            // HallSchedule
            // 
            HallSchedule.HeaderText = "Зал";
            HallSchedule.Name = "HallSchedule";
            HallSchedule.Resizable = DataGridViewTriState.True;
            HallSchedule.Width = 150;
            // 
            // CustomersSchedule
            // 
            CustomersSchedule.HeaderText = "Клиенты";
            CustomersSchedule.Name = "CustomersSchedule";
            CustomersSchedule.Resizable = DataGridViewTriState.True;
            CustomersSchedule.SortMode = DataGridViewColumnSortMode.Automatic;
            CustomersSchedule.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 230);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(84, 23);
            textBox1.TabIndex = 3;
            // 
            // HallsList
            // 
            HallsList.FormattingEnabled = true;
            HallsList.Location = new Point(179, 45);
            HallsList.Name = "HallsList";
            HallsList.Size = new Size(138, 23);
            HallsList.TabIndex = 2;
            // 
            // TrainersList
            // 
            TrainersList.FormattingEnabled = true;
            TrainersList.Location = new Point(8, 45);
            TrainersList.Name = "TrainersList";
            TrainersList.Size = new Size(165, 23);
            TrainersList.TabIndex = 1;
            // 
            // CustomersList
            // 
            CustomersList.FormattingEnabled = true;
            CustomersList.Location = new Point(323, 45);
            CustomersList.Name = "CustomersList";
            CustomersList.Size = new Size(165, 23);
            CustomersList.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 650);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            CustomersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TrainersPage.ResumeLayout(false);
            TrainersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            HallsPage.ResumeLayout(false);
            HallsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            SchedulePage.ResumeLayout(false);
            SchedulePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage CustomersPage;
        private TabPage TrainersPage;
        private TabPage HallsPage;
        private TabPage SchedulePage;
        private Panel UpperWindow;
        private TabControl tabControl1;
        private MenuStrip menuStrip1;
        private DataGridView dataGridView1;
        private Button UnloaderCustomers;
        private Button UploadCustomers;
        private TextBox CustomersFinder;
        private Button CreateCustomersList;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private TextBox TrainersFinder;
        private DataGridView dataGridView2;
        private Label label2;
        private Button UnloadTrainers;
        private Button UploadTrainers;
        private Button CreateTrainersList;
        private OpenFileDialog openFileDialog2;
        private SaveFileDialog saveFileDialog2;
        private TextBox HallsFinder;
        private Button button3;
        private Button UploadHalls;
        private Button CreateHallsList;
        private Label label3;
        private DataGridView dataGridView3;
        private OpenFileDialog openFileDialog3;
        private SaveFileDialog saveFileDialog3;
        private DataGridViewTextBoxColumn Surname_с;
        private DataGridViewTextBoxColumn Name_с;
        private DataGridViewTextBoxColumn Age_с;
        private DataGridViewTextBoxColumn Name_t;
        private DataGridViewTextBoxColumn Surname;
        private DataGridViewTextBoxColumn Age_t;
        private DataGridViewTextBoxColumn Work_t;
        private DataGridViewTextBoxColumn Name_h;
        private OpenFileDialog openFileDialog4;
        private SaveFileDialog saveFileDialog4;
        private TextBox textBox1;
        private ComboBox HallsList;
        private ComboBox TrainersList;
        private ComboBox CustomersList;
        private DataGridView dataGridView4;
        private TextBox textBox2;
        private Button UnloadSchedule;
        private Button UploadSchedule;
        private Button button2;
        private Button TryCreateLesson;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Button button7;
        private Button button6;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label12;
        private Label label11;
        private Label label10;
        private DataGridViewTextBoxColumn DateSchedule;
        private DataGridViewTextBoxColumn TimeSchedule;
        private DataGridViewTextBoxColumn ScheduleTrainer;
        private DataGridViewTextBoxColumn HallSchedule;
        private DataGridViewComboBoxColumn CustomersSchedule;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label4;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox7;
    }
}
namespace Martin_G_Praktika_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.scheduleEntry = new System.Windows.Forms.Panel();
            this.scheduleDate = new System.Windows.Forms.DateTimePicker();
            this.scheduleTeacher = new System.Windows.Forms.ComboBox();
            this.scheduleSubject = new System.Windows.Forms.ComboBox();
            this.button17 = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.schedefesduleTeacher = new System.Windows.Forms.Label();
            this.albl = new System.Windows.Forms.Label();
            this.subjectsEntry = new System.Windows.Forms.Panel();
            this.subjectTeacher = new System.Windows.Forms.ComboBox();
            this.button16 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.subjectName = new System.Windows.Forms.TextBox();
            this.roomsEntry = new System.Windows.Forms.Panel();
            this.roomTeacher = new System.Windows.Forms.ComboBox();
            this.button15 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.roomName = new System.Windows.Forms.TextBox();
            this.coursesEntry = new System.Windows.Forms.Panel();
            this.courseRoom = new System.Windows.Forms.ComboBox();
            this.courseTeacher = new System.Windows.Forms.ComboBox();
            this.button14 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.courseName = new System.Windows.Forms.TextBox();
            this.staffEntry = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.staffJob = new System.Windows.Forms.TextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.staffBirthday = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.staffSurname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.TextBox();
            this.teachersEntry = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.teachersBirthday = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.teachersSurname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.teachersName = new System.Windows.Forms.TextBox();
            this.button11 = new System.Windows.Forms.Button();
            this.tableItems = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studentsEntry = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.studentParentsPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.studentPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.studentAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.studentBirthday = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.studentPersonalCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.studentSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.groupsEntry = new System.Windows.Forms.Panel();
            this.submitGroup = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.studentList = new System.Windows.Forms.ListBox();
            this.groupTeacher = new System.Windows.Forms.ComboBox();
            this.deleteStudent = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.groupName = new System.Windows.Forms.TextBox();
            this.button18 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.scheduleEntry.SuspendLayout();
            this.subjectsEntry.SuspendLayout();
            this.roomsEntry.SuspendLayout();
            this.coursesEntry.SuspendLayout();
            this.staffEntry.SuspendLayout();
            this.teachersEntry.SuspendLayout();
            this.studentsEntry.SuspendLayout();
            this.groupsEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupsEntry);
            this.panel1.Controls.Add(this.scheduleEntry);
            this.panel1.Controls.Add(this.subjectsEntry);
            this.panel1.Controls.Add(this.roomsEntry);
            this.panel1.Controls.Add(this.coursesEntry);
            this.panel1.Controls.Add(this.staffEntry);
            this.panel1.Controls.Add(this.teachersEntry);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.tableItems);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.studentsEntry);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 729);
            this.panel1.TabIndex = 0;
            // 
            // scheduleEntry
            // 
            this.scheduleEntry.Controls.Add(this.scheduleDate);
            this.scheduleEntry.Controls.Add(this.scheduleTeacher);
            this.scheduleEntry.Controls.Add(this.scheduleSubject);
            this.scheduleEntry.Controls.Add(this.button17);
            this.scheduleEntry.Controls.Add(this.Time);
            this.scheduleEntry.Controls.Add(this.schedefesduleTeacher);
            this.scheduleEntry.Controls.Add(this.albl);
            this.scheduleEntry.Location = new System.Drawing.Point(1430, 351);
            this.scheduleEntry.Name = "scheduleEntry";
            this.scheduleEntry.Size = new System.Drawing.Size(633, 362);
            this.scheduleEntry.TabIndex = 18;
            // 
            // scheduleDate
            // 
            this.scheduleDate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.scheduleDate.Location = new System.Drawing.Point(40, 158);
            this.scheduleDate.Name = "scheduleDate";
            this.scheduleDate.Size = new System.Drawing.Size(200, 26);
            this.scheduleDate.TabIndex = 15;
            // 
            // scheduleTeacher
            // 
            this.scheduleTeacher.FormattingEnabled = true;
            this.scheduleTeacher.Location = new System.Drawing.Point(40, 94);
            this.scheduleTeacher.Name = "scheduleTeacher";
            this.scheduleTeacher.Size = new System.Drawing.Size(200, 28);
            this.scheduleTeacher.TabIndex = 14;
            // 
            // scheduleSubject
            // 
            this.scheduleSubject.FormattingEnabled = true;
            this.scheduleSubject.Location = new System.Drawing.Point(40, 32);
            this.scheduleSubject.Name = "scheduleSubject";
            this.scheduleSubject.Size = new System.Drawing.Size(200, 28);
            this.scheduleSubject.TabIndex = 13;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gray;
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button17.ForeColor = System.Drawing.Color.Snow;
            this.button17.Location = new System.Drawing.Point(279, 201);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(314, 116);
            this.button17.TabIndex = 12;
            this.button17.Text = "Submit";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.submitSchedule);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.ForeColor = System.Drawing.Color.White;
            this.Time.Location = new System.Drawing.Point(36, 134);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(113, 20);
            this.Time.TabIndex = 7;
            this.Time.Text = "Date and Time";
            // 
            // schedefesduleTeacher
            // 
            this.schedefesduleTeacher.AutoSize = true;
            this.schedefesduleTeacher.ForeColor = System.Drawing.Color.White;
            this.schedefesduleTeacher.Location = new System.Drawing.Point(36, 71);
            this.schedefesduleTeacher.Name = "schedefesduleTeacher";
            this.schedefesduleTeacher.Size = new System.Drawing.Size(67, 20);
            this.schedefesduleTeacher.TabIndex = 3;
            this.schedefesduleTeacher.Text = "Teacher";
            // 
            // albl
            // 
            this.albl.AutoSize = true;
            this.albl.ForeColor = System.Drawing.Color.White;
            this.albl.Location = new System.Drawing.Point(36, 8);
            this.albl.Name = "albl";
            this.albl.Size = new System.Drawing.Size(63, 20);
            this.albl.TabIndex = 1;
            this.albl.Text = "Subject";
            // 
            // subjectsEntry
            // 
            this.subjectsEntry.Controls.Add(this.subjectTeacher);
            this.subjectsEntry.Controls.Add(this.button16);
            this.subjectsEntry.Controls.Add(this.label21);
            this.subjectsEntry.Controls.Add(this.label22);
            this.subjectsEntry.Controls.Add(this.subjectName);
            this.subjectsEntry.Location = new System.Drawing.Point(1430, 356);
            this.subjectsEntry.Name = "subjectsEntry";
            this.subjectsEntry.Size = new System.Drawing.Size(633, 362);
            this.subjectsEntry.TabIndex = 17;
            // 
            // subjectTeacher
            // 
            this.subjectTeacher.FormattingEnabled = true;
            this.subjectTeacher.Location = new System.Drawing.Point(30, 105);
            this.subjectTeacher.Name = "subjectTeacher";
            this.subjectTeacher.Size = new System.Drawing.Size(211, 28);
            this.subjectTeacher.TabIndex = 13;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Gray;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button16.ForeColor = System.Drawing.Color.Snow;
            this.button16.Location = new System.Drawing.Point(279, 201);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(314, 116);
            this.button16.TabIndex = 12;
            this.button16.Text = "Submit";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.subjectSubmit);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(36, 71);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 20);
            this.label21.TabIndex = 3;
            this.label21.Text = "Teacher";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(36, 8);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(107, 20);
            this.label22.TabIndex = 1;
            this.label22.Text = "Subject name";
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(30, 31);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(207, 26);
            this.subjectName.TabIndex = 0;
            // 
            // roomsEntry
            // 
            this.roomsEntry.Controls.Add(this.roomTeacher);
            this.roomsEntry.Controls.Add(this.button15);
            this.roomsEntry.Controls.Add(this.label19);
            this.roomsEntry.Controls.Add(this.label20);
            this.roomsEntry.Controls.Add(this.roomName);
            this.roomsEntry.Location = new System.Drawing.Point(1430, 356);
            this.roomsEntry.Name = "roomsEntry";
            this.roomsEntry.Size = new System.Drawing.Size(633, 362);
            this.roomsEntry.TabIndex = 16;
            // 
            // roomTeacher
            // 
            this.roomTeacher.FormattingEnabled = true;
            this.roomTeacher.Location = new System.Drawing.Point(30, 105);
            this.roomTeacher.Name = "roomTeacher";
            this.roomTeacher.Size = new System.Drawing.Size(207, 28);
            this.roomTeacher.TabIndex = 13;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Gray;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.ForeColor = System.Drawing.Color.Snow;
            this.button15.Location = new System.Drawing.Point(279, 201);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(314, 116);
            this.button15.TabIndex = 12;
            this.button15.Text = "Submit";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.submitRoom);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(36, 71);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(123, 20);
            this.label19.TabIndex = 3;
            this.label19.Text = "Regular teacher";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(36, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(96, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "Room name";
            // 
            // roomName
            // 
            this.roomName.Location = new System.Drawing.Point(30, 31);
            this.roomName.Name = "roomName";
            this.roomName.Size = new System.Drawing.Size(207, 26);
            this.roomName.TabIndex = 0;
            // 
            // coursesEntry
            // 
            this.coursesEntry.Controls.Add(this.courseRoom);
            this.coursesEntry.Controls.Add(this.courseTeacher);
            this.coursesEntry.Controls.Add(this.button14);
            this.coursesEntry.Controls.Add(this.label15);
            this.coursesEntry.Controls.Add(this.label16);
            this.coursesEntry.Controls.Add(this.label17);
            this.coursesEntry.Controls.Add(this.courseName);
            this.coursesEntry.Location = new System.Drawing.Point(1430, 367);
            this.coursesEntry.Name = "coursesEntry";
            this.coursesEntry.Size = new System.Drawing.Size(633, 362);
            this.coursesEntry.TabIndex = 15;
            // 
            // courseRoom
            // 
            this.courseRoom.FormattingEnabled = true;
            this.courseRoom.Location = new System.Drawing.Point(30, 157);
            this.courseRoom.Name = "courseRoom";
            this.courseRoom.Size = new System.Drawing.Size(207, 28);
            this.courseRoom.TabIndex = 14;
            // 
            // courseTeacher
            // 
            this.courseTeacher.FormattingEnabled = true;
            this.courseTeacher.Location = new System.Drawing.Point(30, 94);
            this.courseTeacher.Name = "courseTeacher";
            this.courseTeacher.Size = new System.Drawing.Size(207, 28);
            this.courseTeacher.TabIndex = 13;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Gray;
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.ForeColor = System.Drawing.Color.Snow;
            this.button14.Location = new System.Drawing.Point(279, 201);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(314, 116);
            this.button14.TabIndex = 12;
            this.button14.Text = "Submit";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.submitCourse);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(36, 134);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Room";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(36, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Teacher";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(36, 8);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Course name";
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(30, 31);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(207, 26);
            this.courseName.TabIndex = 0;
            // 
            // staffEntry
            // 
            this.staffEntry.Controls.Add(this.label12);
            this.staffEntry.Controls.Add(this.staffJob);
            this.staffEntry.Controls.Add(this.button13);
            this.staffEntry.Controls.Add(this.label8);
            this.staffEntry.Controls.Add(this.staffBirthday);
            this.staffEntry.Controls.Add(this.label9);
            this.staffEntry.Controls.Add(this.staffSurname);
            this.staffEntry.Controls.Add(this.label10);
            this.staffEntry.Controls.Add(this.staffName);
            this.staffEntry.Location = new System.Drawing.Point(1430, 367);
            this.staffEntry.Name = "staffEntry";
            this.staffEntry.Size = new System.Drawing.Size(633, 362);
            this.staffEntry.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(36, 201);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Job";
            // 
            // staffJob
            // 
            this.staffJob.Location = new System.Drawing.Point(30, 224);
            this.staffJob.Name = "staffJob";
            this.staffJob.Size = new System.Drawing.Size(207, 26);
            this.staffJob.TabIndex = 13;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Gray;
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.ForeColor = System.Drawing.Color.Snow;
            this.button13.Location = new System.Drawing.Point(279, 201);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(314, 116);
            this.button13.TabIndex = 12;
            this.button13.Text = "Submit";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.submitStaff);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Birthday (DD/MM/YYYY)";
            // 
            // staffBirthday
            // 
            this.staffBirthday.Location = new System.Drawing.Point(30, 157);
            this.staffBirthday.Name = "staffBirthday";
            this.staffBirthday.Size = new System.Drawing.Size(207, 26);
            this.staffBirthday.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Surname";
            // 
            // staffSurname
            // 
            this.staffSurname.Location = new System.Drawing.Point(30, 94);
            this.staffSurname.Name = "staffSurname";
            this.staffSurname.Size = new System.Drawing.Size(207, 26);
            this.staffSurname.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name";
            // 
            // staffName
            // 
            this.staffName.Location = new System.Drawing.Point(30, 31);
            this.staffName.Name = "staffName";
            this.staffName.Size = new System.Drawing.Size(207, 26);
            this.staffName.TabIndex = 0;
            // 
            // teachersEntry
            // 
            this.teachersEntry.Controls.Add(this.button12);
            this.teachersEntry.Controls.Add(this.label11);
            this.teachersEntry.Controls.Add(this.teachersBirthday);
            this.teachersEntry.Controls.Add(this.label13);
            this.teachersEntry.Controls.Add(this.teachersSurname);
            this.teachersEntry.Controls.Add(this.label14);
            this.teachersEntry.Controls.Add(this.teachersName);
            this.teachersEntry.Location = new System.Drawing.Point(1430, 356);
            this.teachersEntry.Name = "teachersEntry";
            this.teachersEntry.Size = new System.Drawing.Size(633, 362);
            this.teachersEntry.TabIndex = 13;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Gray;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.ForeColor = System.Drawing.Color.Snow;
            this.button12.Location = new System.Drawing.Point(279, 201);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(314, 116);
            this.button12.TabIndex = 12;
            this.button12.Text = "Submit";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.submitTeacher);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(36, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(183, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "Birthday (DD/MM/YYYY)";
            // 
            // teachersBirthday
            // 
            this.teachersBirthday.Location = new System.Drawing.Point(30, 157);
            this.teachersBirthday.Name = "teachersBirthday";
            this.teachersBirthday.Size = new System.Drawing.Size(207, 26);
            this.teachersBirthday.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(36, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Surname";
            // 
            // teachersSurname
            // 
            this.teachersSurname.Location = new System.Drawing.Point(30, 94);
            this.teachersSurname.Name = "teachersSurname";
            this.teachersSurname.Size = new System.Drawing.Size(207, 26);
            this.teachersSurname.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(36, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Name";
            // 
            // teachersName
            // 
            this.teachersName.Location = new System.Drawing.Point(30, 31);
            this.teachersName.Name = "teachersName";
            this.teachersName.Size = new System.Drawing.Size(207, 26);
            this.teachersName.TabIndex = 0;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Gray;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.ForeColor = System.Drawing.Color.Snow;
            this.button11.Location = new System.Drawing.Point(404, 419);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(277, 57);
            this.button11.TabIndex = 12;
            this.button11.Text = "Delete selected";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.deleteSelected);
            // 
            // tableItems
            // 
            this.tableItems.BackColor = System.Drawing.Color.LightGray;
            this.tableItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableItems.FormattingEnabled = true;
            this.tableItems.HorizontalScrollbar = true;
            this.tableItems.IntegralHeight = false;
            this.tableItems.ItemHeight = 30;
            this.tableItems.Location = new System.Drawing.Point(404, 41);
            this.tableItems.Name = "tableItems";
            this.tableItems.ScrollAlwaysVisible = true;
            this.tableItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.tableItems.Size = new System.Drawing.Size(912, 304);
            this.tableItems.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Gray;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.Snow;
            this.button9.Location = new System.Drawing.Point(404, 356);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(277, 57);
            this.button9.TabIndex = 9;
            this.button9.Text = "New Entry";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.newEntry);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Gray;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.Snow;
            this.button6.Location = new System.Drawing.Point(49, 482);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(329, 57);
            this.button6.TabIndex = 7;
            this.button6.Text = "Groups";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.groupsPage);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.Snow;
            this.button7.Location = new System.Drawing.Point(49, 419);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(329, 57);
            this.button7.TabIndex = 6;
            this.button7.Text = "Schedule";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.schedulePage);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Gray;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.Snow;
            this.button8.Location = new System.Drawing.Point(49, 356);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(329, 57);
            this.button8.TabIndex = 5;
            this.button8.Text = "Subjects";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.subjectsPage);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Gray;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.Snow;
            this.button5.Location = new System.Drawing.Point(49, 293);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(329, 57);
            this.button5.TabIndex = 4;
            this.button5.Text = "Rooms";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.roomsPage);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Gray;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(49, 230);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(329, 57);
            this.button4.TabIndex = 3;
            this.button4.Text = "Courses";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.coursesPage);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(49, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(329, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Staff";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.staffPage);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(49, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Teachers";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.teachersPage);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(49, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Students";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.studentPage);
            // 
            // studentsEntry
            // 
            this.studentsEntry.Controls.Add(this.button10);
            this.studentsEntry.Controls.Add(this.label7);
            this.studentsEntry.Controls.Add(this.studentParentsPhone);
            this.studentsEntry.Controls.Add(this.label6);
            this.studentsEntry.Controls.Add(this.studentPhone);
            this.studentsEntry.Controls.Add(this.label5);
            this.studentsEntry.Controls.Add(this.studentAddress);
            this.studentsEntry.Controls.Add(this.label4);
            this.studentsEntry.Controls.Add(this.studentBirthday);
            this.studentsEntry.Controls.Add(this.label3);
            this.studentsEntry.Controls.Add(this.studentPersonalCode);
            this.studentsEntry.Controls.Add(this.label2);
            this.studentsEntry.Controls.Add(this.studentSurname);
            this.studentsEntry.Controls.Add(this.label1);
            this.studentsEntry.Controls.Add(this.studentName);
            this.studentsEntry.Location = new System.Drawing.Point(1430, 356);
            this.studentsEntry.Name = "studentsEntry";
            this.studentsEntry.Size = new System.Drawing.Size(633, 362);
            this.studentsEntry.TabIndex = 11;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Gray;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.ForeColor = System.Drawing.Color.Snow;
            this.button10.Location = new System.Drawing.Point(279, 201);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(314, 116);
            this.button10.TabIndex = 12;
            this.button10.Text = "Submit";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.submitStudent);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(285, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Parent\'s phone";
            // 
            // studentParentsPhone
            // 
            this.studentParentsPhone.Location = new System.Drawing.Point(279, 94);
            this.studentParentsPhone.Name = "studentParentsPhone";
            this.studentParentsPhone.Size = new System.Drawing.Size(207, 26);
            this.studentParentsPhone.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(285, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone";
            // 
            // studentPhone
            // 
            this.studentPhone.Location = new System.Drawing.Point(279, 31);
            this.studentPhone.Name = "studentPhone";
            this.studentPhone.Size = new System.Drawing.Size(207, 26);
            this.studentPhone.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(36, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address";
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(30, 291);
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(207, 26);
            this.studentAddress.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Birthday (DD/MM/YYYY)";
            // 
            // studentBirthday
            // 
            this.studentBirthday.Location = new System.Drawing.Point(30, 224);
            this.studentBirthday.Name = "studentBirthday";
            this.studentBirthday.Size = new System.Drawing.Size(207, 26);
            this.studentBirthday.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Personal Code";
            // 
            // studentPersonalCode
            // 
            this.studentPersonalCode.Location = new System.Drawing.Point(30, 157);
            this.studentPersonalCode.Name = "studentPersonalCode";
            this.studentPersonalCode.Size = new System.Drawing.Size(207, 26);
            this.studentPersonalCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // studentSurname
            // 
            this.studentSurname.Location = new System.Drawing.Point(30, 94);
            this.studentSurname.Name = "studentSurname";
            this.studentSurname.Size = new System.Drawing.Size(207, 26);
            this.studentSurname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(30, 31);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(207, 26);
            this.studentName.TabIndex = 0;
            // 
            // groupsEntry
            // 
            this.groupsEntry.Controls.Add(this.button18);
            this.groupsEntry.Controls.Add(this.groupName);
            this.groupsEntry.Controls.Add(this.label18);
            this.groupsEntry.Controls.Add(this.deleteStudent);
            this.groupsEntry.Controls.Add(this.groupTeacher);
            this.groupsEntry.Controls.Add(this.studentList);
            this.groupsEntry.Controls.Add(this.submitGroup);
            this.groupsEntry.Controls.Add(this.label23);
            this.groupsEntry.Controls.Add(this.label24);
            this.groupsEntry.Location = new System.Drawing.Point(687, 356);
            this.groupsEntry.Name = "groupsEntry";
            this.groupsEntry.Size = new System.Drawing.Size(633, 362);
            this.groupsEntry.TabIndex = 19;
            // 
            // submitGroup
            // 
            this.submitGroup.BackColor = System.Drawing.Color.Gray;
            this.submitGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.submitGroup.ForeColor = System.Drawing.Color.Snow;
            this.submitGroup.Location = new System.Drawing.Point(470, 295);
            this.submitGroup.Name = "submitGroup";
            this.submitGroup.Size = new System.Drawing.Size(154, 49);
            this.submitGroup.TabIndex = 12;
            this.submitGroup.Text = "Submit as new";
            this.submitGroup.UseVisualStyleBackColor = false;
            this.submitGroup.Click += new System.EventHandler(this.submitGroups);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(28, 284);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(122, 20);
            this.label23.TabIndex = 3;
            this.label23.Text = "Teacher\'s name";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(25, 48);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(74, 20);
            this.label24.TabIndex = 1;
            this.label24.Text = "Students";
            // 
            // studentList
            // 
            this.studentList.FormattingEnabled = true;
            this.studentList.ItemHeight = 20;
            this.studentList.Location = new System.Drawing.Point(29, 71);
            this.studentList.MultiColumn = true;
            this.studentList.Name = "studentList";
            this.studentList.ScrollAlwaysVisible = true;
            this.studentList.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.studentList.Size = new System.Drawing.Size(465, 204);
            this.studentList.TabIndex = 13;
            // 
            // groupTeacher
            // 
            this.groupTeacher.FormattingEnabled = true;
            this.groupTeacher.Location = new System.Drawing.Point(29, 307);
            this.groupTeacher.Name = "groupTeacher";
            this.groupTeacher.Size = new System.Drawing.Size(265, 28);
            this.groupTeacher.TabIndex = 14;
            // 
            // deleteStudent
            // 
            this.deleteStudent.BackColor = System.Drawing.Color.Gray;
            this.deleteStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteStudent.ForeColor = System.Drawing.Color.Snow;
            this.deleteStudent.Location = new System.Drawing.Point(500, 71);
            this.deleteStudent.Name = "deleteStudent";
            this.deleteStudent.Size = new System.Drawing.Size(124, 49);
            this.deleteStudent.TabIndex = 15;
            this.deleteStudent.Text = "Delete selected";
            this.deleteStudent.UseVisualStyleBackColor = false;
            this.deleteStudent.Click += new System.EventHandler(this.deleteSelectedStudents);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(25, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(102, 20);
            this.label18.TabIndex = 16;
            this.label18.Text = "Group name:";
            // 
            // groupName
            // 
            this.groupName.Location = new System.Drawing.Point(134, 16);
            this.groupName.Name = "groupName";
            this.groupName.Size = new System.Drawing.Size(192, 26);
            this.groupName.TabIndex = 17;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.Gray;
            this.button18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.05594F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button18.ForeColor = System.Drawing.Color.Snow;
            this.button18.Location = new System.Drawing.Point(310, 295);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(154, 49);
            this.button18.TabIndex = 18;
            this.button18.Text = "Update";
            this.button18.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 730);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.scheduleEntry.ResumeLayout(false);
            this.scheduleEntry.PerformLayout();
            this.subjectsEntry.ResumeLayout(false);
            this.subjectsEntry.PerformLayout();
            this.roomsEntry.ResumeLayout(false);
            this.roomsEntry.PerformLayout();
            this.coursesEntry.ResumeLayout(false);
            this.coursesEntry.PerformLayout();
            this.staffEntry.ResumeLayout(false);
            this.staffEntry.PerformLayout();
            this.teachersEntry.ResumeLayout(false);
            this.teachersEntry.PerformLayout();
            this.studentsEntry.ResumeLayout(false);
            this.studentsEntry.PerformLayout();
            this.groupsEntry.ResumeLayout(false);
            this.groupsEntry.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox tableItems;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Panel studentsEntry;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox studentParentsPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox studentAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentBirthday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentPersonalCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox studentSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Panel teachersEntry;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox teachersBirthday;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox teachersSurname;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox teachersName;
        private System.Windows.Forms.Panel staffEntry;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox staffBirthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox staffSurname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox staffName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox staffJob;
        private System.Windows.Forms.Panel coursesEntry;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.ComboBox courseRoom;
        private System.Windows.Forms.ComboBox courseTeacher;
        private System.Windows.Forms.Panel roomsEntry;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox roomName;
        private System.Windows.Forms.ComboBox roomTeacher;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel subjectsEntry;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox subjectName;
        private System.Windows.Forms.ComboBox subjectTeacher;
        private System.Windows.Forms.Panel scheduleEntry;
        private System.Windows.Forms.DateTimePicker scheduleDate;
        private System.Windows.Forms.ComboBox scheduleTeacher;
        private System.Windows.Forms.ComboBox scheduleSubject;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label schedefesduleTeacher;
        private System.Windows.Forms.Label albl;
        private System.Windows.Forms.Panel groupsEntry;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox groupName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button deleteStudent;
        private System.Windows.Forms.ComboBox groupTeacher;
        private System.Windows.Forms.ListBox studentList;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button submitGroup;
    }
}


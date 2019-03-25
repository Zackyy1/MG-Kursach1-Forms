using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Xml;
using System.IO;
using System.Diagnostics;
namespace Martin_G_Praktika_Forms
{

    

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!File.Exists("DB.xml"))
            {
                
            XmlWriter xmlWriter = XmlWriter.Create("DB.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("DataBase");
                xmlWriter.WriteStartElement("Students");
                
                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Teachers");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Staff");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Courses");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Rooms");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Groups");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Subjects");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Schedule");

                xmlWriter.WriteEndElement();
                xmlWriter.WriteStartElement("Groups");

                xmlWriter.WriteEndElement();
                



                xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Close();
            }
            else
            {
                // Update function for students, for now.
                showStudents();
                activePanel = studentsEntry;
                activePanel.Location = new Point(activePanel.Location.X - 500, activePanel.Location.Y);
                activePanel.Left += 500;
                

            }
        }

        public string active = "Student";
        public Panel activePanel;

        public void hideEntries()
        {
            if (activePanel.Left > 700)
            {
                //activePanel.Left -= 500;
            }
            else
            {
                activePanel.Left += 500;

            }
        }

        private void newEntry(object sender, EventArgs e)
        {
            //activePanel.Location = new Point(698, 356);
            if (activePanel.Left > 700)
            {
                activePanel.Left -= 500;
            } else
            {
                activePanel.Left += 500;

            }

        }

        private void deleteSelected(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList list = xml.GetElementsByTagName(active);

            for (int i = 0; tableItems.Items.Count > 0; i++)
            {

                if (i == tableItems.SelectedIndex)
                {
                    list[i].ParentNode.RemoveChild(list[i]);
                    tableItems.Items.Remove(tableItems.Items[i]);
                    break;
                }
            }
            xml.Save("DB.xml");

        }

        
        private void showStudents()
        {
            active = "Student";
            activePanel = studentsEntry;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList studentsList = xml.GetElementsByTagName("Student");
            Debug.WriteLine(studentsList.Count);
            foreach (XmlElement student in studentsList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("name".ToString()) + " ");
                sb.Append(student.GetAttribute("surname".ToString()) + " | ");
                sb.Append(student.GetAttribute("personalCode".ToString()) + " | ");
                sb.Append(student.GetAttribute("birthday".ToString()) + " | ");
                sb.Append(student.GetAttribute("address".ToString()) + " | ");
                sb.Append(student.GetAttribute("phone".ToString()) + " | ");
                sb.Append(student.GetAttribute("parentsPhone".ToString()));

                tableItems.Items.Add(sb.ToString());
            }
        }
        private void submitStudent(object sender, EventArgs e)
        {
            string name = studentName.Text;
            string surname = studentSurname.Text;
            string personalCode = studentPersonalCode.Text;
            string birthday = studentBirthday.Text;
            string address = studentAddress.Text;
            string phone = studentPhone.Text;
            string parentsPhone = studentParentsPhone.Text;

            if (name.Length < 1 || surname.Length < 1 || personalCode.Length < 1 || birthday.Length < 1 ||
                address.Length < 1 || phone.Length < 1 || parentsPhone.Length < 1)
            {
                Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
            }
            else
            {
                Student newstud = new Student(name, surname, personalCode, birthday, address, phone, parentsPhone);
                newstud.addNewStudent(tableItems, studentName, studentSurname, studentPersonalCode, studentBirthday, studentAddress, studentPhone, studentParentsPhone);

            }

        }
        private void studentPage(object sender, EventArgs e)
        {
            hideEntries();
            tableItems.SelectionMode = SelectionMode.MultiSimple;

            tableItems.Items.Clear();
            showStudents();
        }


        private void showTeachers()
        {
            active = "Teacher";
            activePanel = teachersEntry;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList teachersList = xml.GetElementsByTagName("Teacher");
            Debug.WriteLine(teachersList.Count);
            foreach (XmlElement student in teachersList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("name".ToString()) + " ");
                sb.Append(student.GetAttribute("surname".ToString()) + " | ");
                sb.Append(student.GetAttribute("birthday".ToString()));
                
                tableItems.Items.Add(sb.ToString());
            }
        }
        private void teachersPage(object sender, EventArgs e)
        {
            hideEntries();
            tableItems.SelectionMode = SelectionMode.MultiSimple;

            tableItems.Items.Clear();
            showTeachers();
        }
        private void submitTeacher(object sender, EventArgs e)
        {
            string name = teachersName.Text;
            string surname = teachersSurname.Text;
            string birthday = teachersBirthday.Text;


            if (name.Length < 1 || surname.Length < 1 || birthday.Length < 1)
            {
                Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
            }
            else
            {
                Teacher newstud = new Teacher(name, surname, birthday);
                newstud.addNewTeacher(tableItems, teachersName, teachersSurname, teachersBirthday);

            }
        }

        private void showStaff()
        {
            active = "Worker";
            activePanel = staffEntry;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList teachersList = xml.GetElementsByTagName("Worker");
            Debug.WriteLine(teachersList.Count);
            foreach (XmlElement student in teachersList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("name".ToString()) + " ");
                sb.Append(student.GetAttribute("surname".ToString()) + " | ");
                sb.Append(student.GetAttribute("birthday".ToString()) + " | ");
                sb.Append(student.GetAttribute("job".ToString()));


                tableItems.Items.Add(sb.ToString());
            }
        }
        private void staffPage(object sender, EventArgs e)
        {
            hideEntries();
            tableItems.SelectionMode = SelectionMode.MultiSimple;

            tableItems.Items.Clear();
            showStaff();
        }
        private void submitStaff(object sender, EventArgs e)
        {
            string name = staffName.Text;
            string surname = staffSurname.Text;
            string birthday = staffBirthday.Text;
            string job = staffJob.Text;


            if (name.Length < 1 || surname.Length < 1 || birthday.Length < 1)
            {
                Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
            }
            else
            {
                Staff newstud = new Staff(name, surname, birthday, job);
                newstud.addNewStaff(tableItems, staffName, staffSurname, staffBirthday, staffJob);

            }
        }

        private void showCourses()
        {
            active = "Course";
            activePanel = coursesEntry;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList teachersList = xml.GetElementsByTagName("Course");
            Debug.WriteLine(teachersList.Count);
            foreach (XmlElement student in teachersList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("name".ToString()) + " - ");
                sb.Append(student.GetAttribute("teacher".ToString()) + " | ");
                sb.Append(student.GetAttribute("room".ToString()));


                tableItems.Items.Add(sb.ToString());
            }
            XmlNodeList teachers = xml.GetElementsByTagName("Teacher");
            courseTeacher.Items.Clear();
                foreach (XmlElement teacher in teachers)
                {
                    courseTeacher.Items.Add(teacher.GetAttribute("name") + " " + teacher.GetAttribute("surname"));
                }
            

            XmlNodeList rooms = xml.GetElementsByTagName("Room");
            courseRoom.Items.Clear();
            courseRoom.Items.Add("Shared");

            foreach (XmlElement room in rooms)
                {
                    courseRoom.Items.Add(room.GetAttribute("name"));
                }
            
        }
        private void coursesPage(object sender, EventArgs e)
        {
            hideEntries();
            tableItems.SelectionMode = SelectionMode.MultiSimple;

            tableItems.Items.Clear();
            showCourses();
        }
        private void submitCourse(object sender, EventArgs e)
        {

            string name = courseName.Text;
            string teacher = courseTeacher.Text;
            string room = courseRoom.Text;


            if (name.Length < 1 || teacher.Length < 1 || room.Length < 1)
            {
                Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
            }
            else
            {
                Course newstud = new Course(name, teacher, room);
                newstud.addNewCourse(tableItems, courseName, courseTeacher, courseRoom);

            }
        }

        private void showRooms()
        {
            active = "Room";
            activePanel = roomsEntry;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList teachersList = xml.GetElementsByTagName("Room");
            Debug.WriteLine(teachersList.Count);
            foreach (XmlElement student in teachersList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("name".ToString()) + " - ");

                sb.Append(student.GetAttribute("roomTeacher".ToString()));


                tableItems.Items.Add(sb.ToString());
            }
            XmlNodeList teachers = xml.GetElementsByTagName("Teacher");
            roomTeacher.Items.Clear();
            foreach (XmlElement teacher in teachers)
            {
                roomTeacher.Items.Add(teacher.GetAttribute("name") + " " + teacher.GetAttribute("surname"));
            }
        }
        private void roomsPage(object sender, EventArgs e)
        {
            hideEntries();
            tableItems.SelectionMode = SelectionMode.MultiSimple;

            tableItems.Items.Clear();
            showRooms();
        }
        private void submitRoom(object sender, EventArgs e)
        {
            string name = roomName.Text;
            string teacher = roomTeacher.Text;

            if (name.Length < 1 || teacher.Length < 1)
            {
                Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
            }
            else
            {
                Room newstud = new Room(name, teacher);
                newstud.addNewRoom(tableItems, roomName, roomTeacher);

            }
        }

        private void showSubjects()
        {
            active = "Subject";
            activePanel = subjectsEntry;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList teachersList = xml.GetElementsByTagName("Subject");
            Debug.WriteLine(teachersList.Count);
            foreach (XmlElement student in teachersList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("name".ToString()) + " - ");

                sb.Append(student.GetAttribute("teacher".ToString()));


                tableItems.Items.Add(sb.ToString());
            }
            XmlNodeList teachers = xml.GetElementsByTagName("Teacher");
            subjectTeacher.Items.Clear();
            foreach (XmlElement teacher in teachers)
            {
                subjectTeacher.Items.Add(teacher.GetAttribute("name") + " " + teacher.GetAttribute("surname"));
            }
        }
        private void subjectSubmit(object sender, EventArgs e)
        {
            string name = subjectName.Text;
            string teacher = subjectTeacher.Text;

            if (name.Length < 1 || teacher.Length < 1)
            {
                Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
            }
            else
            {
                Subject newstud = new Subject(name, teacher);
                newstud.addNewSubject(tableItems, subjectName, subjectTeacher);

            }
        }
        private void subjectsPage(object sender, EventArgs e)
        {
            hideEntries();
            tableItems.SelectionMode = SelectionMode.MultiSimple;

            tableItems.Items.Clear();
            showSubjects();
        }

        private void showSchedule()
        {
            active = "ScheduleEntry";
            activePanel = scheduleEntry;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList teachersList = xml.GetElementsByTagName("ScheduleEntry");
            Debug.WriteLine(teachersList.Count);
            foreach (XmlElement student in teachersList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("subject".ToString()) + " - ");
                sb.Append(student.GetAttribute("teacher".ToString()) + " - ");

                sb.Append(student.GetAttribute("date".ToString()));


                tableItems.Items.Add(sb.ToString());
            }
            XmlNodeList teachers = xml.GetElementsByTagName("Teacher");
            scheduleTeacher.Items.Clear();
            foreach (XmlElement teacher in teachers)
            {
                scheduleTeacher.Items.Add(teacher.GetAttribute("name") + " " + teacher.GetAttribute("surname"));
            }
            XmlNodeList subjects = xml.GetElementsByTagName("Subject");
            scheduleSubject.Items.Clear();
            foreach (XmlElement subject in subjects)
            {
                scheduleSubject.Items.Add(subject.GetAttribute("name") + " " + subject.GetAttribute("surname"));
            }
        }
        private void schedulePage(object sender, EventArgs e)
        {
            hideEntries();
            tableItems.SelectionMode = SelectionMode.MultiSimple;

            tableItems.Items.Clear();
            showSchedule();
        }
        private void submitSchedule(object sender, EventArgs e)
        {
            {
                string teacher = scheduleTeacher.Text;
                string subject = scheduleSubject.Text;
                string date = scheduleDate.Text;

                if (teacher.Length < 1 || subject.Length < 1)
                {
                    Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
                }
                else
                {
                    Schedule newstud = new Schedule(teacher, subject, date);
                    newstud.addNewSchedule(tableItems, scheduleTeacher, scheduleSubject, scheduleDate);

                }
            }
        }

        private void groupsPage(object sender, EventArgs e)
        {
            hideEntries();
            active = "Group";
            activePanel = groupsEntry;
            if (activePanel.Left > 700)
            {
                activePanel.Left -= 500;
            }
            else
            {
                activePanel.Left += 500;

            }
            tableItems.SelectionMode = SelectionMode.One;
            tableItems.Items.Clear();
            showGroups();
        }
        private void showGroups()
        {
            
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList teachersList = xml.GetElementsByTagName("Group");
            Debug.WriteLine(teachersList.Count);
            foreach (XmlElement student in teachersList)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(student.GetAttribute("name".ToString()) + " - ");
                sb.Append(student.GetAttribute("teacher".ToString()));

                tableItems.Items.Add(sb.ToString());
            }
            XmlNodeList teachers = xml.GetElementsByTagName("Teacher");
            groupTeacher.Items.Clear();
            foreach (XmlElement teacher in teachers)
            {
                groupTeacher.Items.Add(teacher.GetAttribute("name") + " " + teacher.GetAttribute("surname"));
            }

            XmlNodeList students = xml.GetElementsByTagName("Student");
            studentList.Items.Clear();
            foreach (XmlElement student in students)
            {
                studentList.Items.Add(student.GetAttribute("name") + " " + student.GetAttribute("surname"));
            }


            
        }
        private void submitGroups(object sender, EventArgs e)
        {
            string name = groupName.Text;
            string teacher = groupTeacher.Text;
            string[] students = { };
            
            /*
             * foreach (string obj in studentList.Items) {
                //students.Append(studentList.GetItemText(obj));
                students.Append(obj);

            }
            */

            if (name.Length < 1 || teacher.Length < 1)
            {
                Debug.WriteLine("ERROR: NOT ALL FIELDS ARE FILLED");
            }
            else
            {
                Group newstud = new Group(name, teacher, students);
                newstud.addNewGroup(tableItems, groupName, groupTeacher, students, studentList);

            }
        }

        private void deleteSelectedStudents(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList groupList = xml.GetElementsByTagName("Group");
            foreach (XmlElement group in groupList)
            {
                if (group.GetAttribute("name") == groupName.Text)
                {

                   
                    
                    for (int i = studentList.SelectedIndices.Count-1; i >= 0 ; i--)
                    {
                        string toDelete = studentList.SelectedItems[i].ToString();
                        XmlNodeList members = group.GetElementsByTagName("GroupMember");
                       
                        for (int b = members.Count-1; b >= 0; b--)
                        {
                            if (members[b].Attributes["name"].Value == toDelete)
                            {
                                group.RemoveChild(members[b]);
                                studentList.Items.RemoveAt(b);
                            }
                        }

                    }
                
                    /*
                           foreach (XmlElement check in members)
                           {
                               if (check.GetAttribute("name") == toDelete)
                               {
                                   group.RemoveChild(check);
                                   studentList.Items.RemoveAt(i);
                               }
                           }
                           */
                }
            }
            xml.Save("DB.xml");
           
        }

        private void addNewToGroup(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList students = xml.GetElementsByTagName("Student");
            studentList.Items.Clear();
            foreach (XmlElement student in students)
            {
                studentList.Items.Add(student.GetAttribute("name") + " " + student.GetAttribute("surname"));
            }
        }





        private void updateStudentList(object sender, EventArgs e)
        {
            if (active == "Group" && tableItems.SelectedIndices.Count == 1)
            {
                studentList.Items.Clear();
                XmlDocument xml = new XmlDocument();
                xml.Load("DB.xml");
                XmlNodeList groupList = xml.GetElementsByTagName("Group");
                int selectedIndex = tableItems.SelectedIndex;
                XmlNode chosenGroup = groupList[selectedIndex];
                
                List<string> members = new List<string>();
                foreach (XmlElement child in chosenGroup.ChildNodes)
                {
                    groupName.Text = child.ParentNode.Attributes[0].InnerXml.ToString();
                    members.Add(child.GetAttribute("name"));
                    Debug.WriteLine($"Added {child.GetAttribute("name")}");
                }
                foreach (string dude in members)
                {
                    studentList.Items.Add(dude);
                }

                
            }
        }

        private void updateGroupChanges(object sender, EventArgs e)
        {
            string groupToFind = groupName.Text;
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            XmlNodeList groups = xml.GetElementsByTagName("Group");
            XmlElement group = xml.CreateElement("temp");
            
            
            foreach (XmlElement g in groups)
            {
                if (g.GetAttribute("name") == groupToFind)
                {
                    group = g;
                }
            }

            foreach (string newStudent in studentList.SelectedItems)
            {
                XmlElement newMember = xml.CreateElement("GroupMember");
                newMember.SetAttribute("name", newStudent);
                group.AppendChild(newMember);
            }
            xml.Save("DB.xml");


        }
    }

    // ------------------------------------     CLASSES     ------------------------------------------------------------------

    class Student
    {
        string name, surname;
        string personalCode;
        string birthday;
        string address;
        string phone, parentsPhone;

        public Student(string name, string surname, string personalCode, string birthday, string address, string phone, string parentsPhone)
        {
            this.name = name;
            this.surname = surname;
            this.personalCode = personalCode;
            this.birthday = birthday;
            this.address = address;
            this.phone = phone;
            this.parentsPhone = parentsPhone;
        }

        public void addNewStudent(ListBox tableItems, TextBox studentName, TextBox studentSurname, TextBox studentPersonalCode, TextBox studentBirthday, TextBox studentAddress, TextBox studentPhone, TextBox studentParentsPhone)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            var node = xml.SelectSingleNode("//DataBase/Students");
            XmlElement newStudent = xml.CreateElement("Student");
            newStudent.SetAttribute("name", name);
            newStudent.SetAttribute("surname", surname);
            newStudent.SetAttribute("personalCode", personalCode);
            newStudent.SetAttribute("birthday", birthday);
            newStudent.SetAttribute("address", address);
            newStudent.SetAttribute("phone", phone);
            newStudent.SetAttribute("parentsPhone", parentsPhone);
            node.AppendChild(newStudent);

            xml.Save("DB.xml");

            StringBuilder sb = new StringBuilder();
            sb.Append(newStudent.GetAttribute("name".ToString()) + " ");
            sb.Append(newStudent.GetAttribute("surname".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("personalCode".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("birthday".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("address".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("phone".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("parentsPhone".ToString()));

            tableItems.Items.Add(sb.ToString());

            studentName.Text = "";
            studentSurname.Text = "";
            studentBirthday.Text = "";
            studentPersonalCode.Text = "";
            studentAddress.Text = "";
            studentPhone.Text = "";
            studentParentsPhone.Text = "";
        }



    }
    class Teacher
    {

        // Name, birthday, subjects

        string name, surname, birthday;

        public Teacher(string name, string surname, string birthday)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
        }

        public void addNewTeacher(ListBox tableItems, TextBox teachersName, TextBox teachersSurname, TextBox teachersBirthday)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            var node = xml.SelectSingleNode("//DataBase/Teachers");
            XmlElement newStudent = xml.CreateElement("Teacher");
            newStudent.SetAttribute("name", name);
            newStudent.SetAttribute("surname", surname);
            newStudent.SetAttribute("birthday", birthday);
           
            node.AppendChild(newStudent);

            xml.Save("DB.xml");

            StringBuilder sb = new StringBuilder();
            sb.Append(newStudent.GetAttribute("name".ToString()) + " ");
            sb.Append(newStudent.GetAttribute("surname".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("birthday".ToString()));
            
            tableItems.Items.Add(sb.ToString());

            teachersName.Text = "";
            teachersSurname.Text = "";
            teachersBirthday.Text = "";
            
        }

    }
    class Staff
    {
        string name, surname, job, birthday;

        public Staff(string name, string surname, string job, string birthday)
        {
            this.name = name;
            this.surname = surname;
            this.job = job;
            this.birthday = birthday;
        }

        public void addNewStaff(ListBox tableItems, TextBox staffName, TextBox staffSurname, TextBox staffBirthday, TextBox staffJob)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            var node = xml.SelectSingleNode("//DataBase/Staff");
            XmlElement newStudent = xml.CreateElement("Worker");
            newStudent.SetAttribute("name", name);
            newStudent.SetAttribute("surname", surname);
            newStudent.SetAttribute("birthday", birthday);
            newStudent.SetAttribute("job", job);

            node.AppendChild(newStudent);

            xml.Save("DB.xml");

            StringBuilder sb = new StringBuilder();
            sb.Append(newStudent.GetAttribute("name".ToString()) + " ");
            sb.Append(newStudent.GetAttribute("surname".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("birthday".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("job".ToString()));


            tableItems.Items.Add(sb.ToString());

            staffName.Text = "";
            staffSurname.Text = "";
            staffBirthday.Text = "";
            staffJob.Text = "";

        }
    }
    class Course
    {
        string name, teacher, room;

        public Course(string name, string teacher, string room)
        {
            this.name = name;
            this.teacher = teacher;
            this.room = room;
        }

        public void addNewCourse(ListBox tableItems, TextBox courseName, ComboBox courseTeacher, ComboBox courseRoom)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            var node = xml.SelectSingleNode("//DataBase/Courses");
            XmlElement newStudent = xml.CreateElement("Course");
            newStudent.SetAttribute("name", name);
            newStudent.SetAttribute("teacher", teacher);
            newStudent.SetAttribute("room", room);

            node.AppendChild(newStudent);

            xml.Save("DB.xml");

            StringBuilder sb = new StringBuilder();
            sb.Append(newStudent.GetAttribute("name".ToString()) + " - ");
            sb.Append(newStudent.GetAttribute("teacher".ToString()) + " | ");
            sb.Append(newStudent.GetAttribute("room".ToString()));


            tableItems.Items.Add(sb.ToString());

            courseName.Text = "";
            courseTeacher.Text = "";
            courseRoom.Text = "";

        }
    }
    class Room
    {
        // max seats, room name
        string name, teacher;

        public Room(string name, string teacher)
        {
            this.name = name;
            this.teacher = teacher;
        }

        public void addNewRoom(ListBox tableItems, TextBox roomName, ComboBox roomTeacher)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            var node = xml.SelectSingleNode("//DataBase/Rooms");
            XmlElement newStudent = xml.CreateElement("Room");
            newStudent.SetAttribute("name", name);
            newStudent.SetAttribute("roomTeacher", teacher);

            node.AppendChild(newStudent);

            xml.Save("DB.xml");

            StringBuilder sb = new StringBuilder();
            sb.Append(newStudent.GetAttribute("name".ToString()) + " - ");
            sb.Append(newStudent.GetAttribute("roomTeacher".ToString()));


            tableItems.Items.Add(sb.ToString());

            roomName.Text = "";
            roomTeacher.Text = "";

        }

    }
    class Group
    {
        // add multiple students to one group
        string name, teacher;
        string[] students;

        public Group(string name, string teacher, string[] students)
        {
            this.name = name;
            this.teacher = teacher;
            this.students = students;
        }

        public void addNewGroup(ListBox tableItems, TextBox groupName, ComboBox groupTeacher, string[] students, ListBox studentList)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            var node = xml.SelectSingleNode("//DataBase/Groups");
            XmlElement newStudent = xml.CreateElement("Group");
            newStudent.SetAttribute("name", name);
            newStudent.SetAttribute("teacher", teacher);


            /*
             foreach (string student in students)
            {
                XmlElement s = xml.CreateElement("groupStudent");
                s.SetAttribute("name", student);
                node.AppendChild(s);

                // TODO: узнать че за хрень

            }
            */

            for (int i =0; i < studentList.SelectedIndices.Count; i++)
            {
                Debug.WriteLine($"Added {studentList.Items[i]} into the list");
                XmlElement newMember = xml.CreateElement("GroupMember");
                newMember.SetAttribute("name", studentList.Items[i].ToString());
                newStudent.AppendChild(newMember);
            }


            node.AppendChild(newStudent);

            xml.Save("DB.xml");

            StringBuilder sb = new StringBuilder();
            sb.Append(newStudent.GetAttribute("name".ToString()) + " - ");
            sb.Append(newStudent.GetAttribute("teacher".ToString()));


            tableItems.Items.Add(sb.ToString());

            groupName.Text = "";
            groupTeacher.Text = "";
            studentList.Items.Clear();


        }

    }
    class Subject
    {

        string name, teacher;

        public Subject(string name, string teacher)
        {
            this.name = name;
            this.teacher = teacher;
        }

        public void addNewSubject(ListBox tableItems, TextBox subjectName, ComboBox subjectTeacher)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("DB.xml");
            var node = xml.SelectSingleNode("//DataBase/Subjects");
            XmlElement newStudent = xml.CreateElement("Subject");
            newStudent.SetAttribute("name", name);
            newStudent.SetAttribute("teacher", teacher);

            node.AppendChild(newStudent);

            xml.Save("DB.xml");

            StringBuilder sb = new StringBuilder();
            sb.Append(newStudent.GetAttribute("name".ToString()) + " - ");
            sb.Append(newStudent.GetAttribute("teacher".ToString()));


            tableItems.Items.Add(sb.ToString());

            subjectName.Text = "";
            subjectTeacher.Text = "";

        }
    }
    class Schedule
    {
            // idk how to make this one
            string teacher, subject, date;

            public Schedule(string teacher, string subject, string date)
            {
                this.teacher = teacher;
                this.subject = subject;
                this.date = date;
            }
            public void addNewSchedule(ListBox tableItems, ComboBox scheduleTeacher, ComboBox scheduleSubject, DateTimePicker scheduleDate)
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("DB.xml");
                var node = xml.SelectSingleNode("//DataBase/Schedule");
                XmlElement newStudent = xml.CreateElement("ScheduleEntry");
                newStudent.SetAttribute("teacher", teacher);
                newStudent.SetAttribute("subject", subject);
                newStudent.SetAttribute("date", scheduleDate.Value.ToString());

                node.AppendChild(newStudent);

                xml.Save("DB.xml");

                StringBuilder sb = new StringBuilder();
                sb.Append(newStudent.GetAttribute("subject".ToString()) + " - ");
                sb.Append(newStudent.GetAttribute("teacher".ToString()) + " - ");
                sb.Append(newStudent.GetAttribute("date".ToString()));


                tableItems.Items.Add(sb.ToString());

                scheduleTeacher.Text = "";
                scheduleSubject.Text = "";

            }
        }
    class Lesson
    {
        // teacher, group, room
    }
    class Grade
    {
        // awarded to students
    }

   
}








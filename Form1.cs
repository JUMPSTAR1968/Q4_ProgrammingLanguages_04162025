using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudentDetailsApp
{
    public partial class Form1 : Form
    {
        // Create a Student class
        public class Student
        {
            public int Student_Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int Age { get; set; }
            public string Birthday_Month { get; set; } = string.Empty;
            public int Birthday_Day { get; set; }
            public int Birthday_Year { get; set; }
        }

        // Create a list of students
        private List<Student> students = new List<Student>
        {
            new Student { Student_Id = 24759, Name = "Casanova, Warleyne Españo", Age = 17, Birthday_Day = 22, Birthday_Month = "January", Birthday_Year = 2008 },
            new Student { Student_Id = 24731, Name = "Inez, Juan Miguel Loro", Age = 18, Birthday_Day = 10, Birthday_Month = "April", Birthday_Year = 2007 },
            new Student { Student_Id = 24776, Name = "Lopez, Jedidiah Hubbard", Age = 18, Birthday_Day = 20, Birthday_Month = "October", Birthday_Year = 2006 },
            new Student { Student_Id = 24752, Name = "Manzano, Arjan Jhames Alpas", Age = 17, Birthday_Day = 12, Birthday_Month = "October", Birthday_Year = 2007 },
            new Student { Student_Id = 24669, Name = "Siruno, Andrei Bautista", Age = 16, Birthday_Day = 3, Birthday_Month = "July", Birthday_Year = 2008 }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStudentId.Text, out int enteredId))
            {
                Student? foundStudent = students.Find(s => s.Student_Id == enteredId);

                if (foundStudent != null)
                {
                    lblName.Text = "Name: " + foundStudent.Name;
                    lblDob.Text = "Date of Birth: " + $"{foundStudent.Birthday_Month} {foundStudent.Birthday_Day}, {foundStudent.Birthday_Year}";
                    lblAge.Text = "Age: " + foundStudent.Age.ToString();
                }
                else
                {
                    lblName.Text = "Student not found.";
                    lblDob.Text = "";
                    lblAge.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Student ID number.");
            }
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

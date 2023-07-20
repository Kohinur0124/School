using School.Core.Model;
using School.Core.Service;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace School
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceModel.UpdateStudent(new Student()
            {
                StudentId = 1,
                FullName = "Xayriddinova Sevinch",
                DOB = "01.02.2004",
                Yonalish = Sub.Aniq,
                Grade = 11,
                PhoneNumber = "+998939613663",
                Password = "Qwert123",
                Mark = 90

            });
            ServiceModel.DeleteStudent(new Student()
            {
                StudentId = 1,
                FullName = "Xayriddinova Sevinch",
                DOB = "01.02.2004",
                Yonalish = Sub.Aniq,
                Grade = 11,
                PhoneNumber = "+998939613663",
                Password = "Qwert123",
                Mark = 90

            });

            ServiceModel.AddStudent(new Student()
            {
                StudentId = 1,
                FullName = "Xayriddinova Sevinch",
                DOB = "01.02.2004",
                Yonalish = Sub.Aniq,
                Grade = 11,
                PhoneNumber = "+998939613663",
                Password = "Qwert123",
                Mark = 95

            });

            var str = ServiceModel.GetAllStudents();
        }
    }
}
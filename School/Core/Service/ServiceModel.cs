using School.Core.Data;
using School.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Service
{
    public static class ServiceModel
    {

        public  static void UpdateStudent (Student student)
        {
            var db  =  new  SchoolDb ();
            
            db.Students.Update (student);

            db.SaveChanges ();
        }

        public static void DeleteStudent (Student student)
        {
            var db = new SchoolDb ();

            db.Remove (student);

            db.SaveChanges ();
        }

        public static void AddStudent (Student student)
        {
            var db = new SchoolDb();

            db.Students.Add (student);

            db.SaveChanges ();
        }

        public static List<Student> GetAllStudents()
        {
            var db = new SchoolDb();

            return db.Students.ToList();


        }

    }
}

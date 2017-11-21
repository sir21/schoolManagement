using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",RegistrationDate=DateTime.Parse("2017-09-24"), DOB=DateTime.Parse("1993-04-22"), Address="Kandy", GuardianName="Jackson"},
                new Student{FirstName="John",LastName="Michal",RegistrationDate=DateTime.Parse("2017-09-24"), DOB=DateTime.Parse("1992-09-12"), Address="Colombo", GuardianName="David"},
                new Student{FirstName="Gran",LastName="Harper",RegistrationDate=DateTime.Parse("2017-09-24"), DOB=DateTime.Parse("1995-05-27"), Address="Negambo", GuardianName="Michel"},
                new Student{FirstName="Elle",LastName="White",RegistrationDate=DateTime.Parse("2017-09-24"), DOB=DateTime.Parse("1997-11-03"), Address="Galle", GuardianName="Andrew"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var subjects = new Subject[]
            {
            new Subject{SubjectID="G1201",SubjectName="Chemistry"},
            new Subject{SubjectID="G1202",SubjectName="Maths"},
            new Subject{SubjectID="G1203",SubjectName="Bio"},
            new Subject{SubjectID="G1204",SubjectName="Pysics"},
            new Subject{SubjectID="G1301",SubjectName="Chemestry"},
            new Subject{SubjectID="G1302",SubjectName="Maths"},
            new Subject{SubjectID="G1303",SubjectName="Bio"}
            };
            foreach (Subject c in subjects)
            {
                context.Subjects.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrolled[]
            {
                new Enrolled{EnrolmentID=1, StudentID=1, SubjectID="G1303", Marks=67},
                new Enrolled{EnrolmentID=2, StudentID=1, SubjectID="G1301", Marks=65},
                new Enrolled{EnrolmentID=3, StudentID=1, SubjectID="G1302", Marks=87},
                new Enrolled{EnrolmentID=4, StudentID=1, SubjectID="G1203", Marks=72},
                new Enrolled{EnrolmentID=5, StudentID=1, SubjectID="G1203", Marks=89},
            };
            foreach (Enrolled e in enrollments)
            {
                context.Enrolled.Add(e);
            }
            context.SaveChanges();
        }
    }

}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLab_6.Models;

namespace EntityLab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddStudent();
            //AddCourse();
            //AddEnrollment();
            //Console.ReadLine();
            Console.WriteLine("\n**************************\n");

            //using (var ctx = new EntityConnector())
            //{
            //    var stud = ctx.Students.Include(s => s.Enrollments).ToList();
            //    foreach (var stu in stud)
            //    {
            //        Console.WriteLine($"StudentID: {stu.StudentId} \nFirstMidName: {stu.FirstMidName} {stu.LastName}");
            //        foreach (var enr in stu.Enrollments)
            //        {
            //            Console.WriteLine($"CourseID: {enr.CourseId} \nEnrollmentID: {enr.EnrollmentId}\n");
            //        }
            //    }
            //    Console.ReadLine();
            //}

            using (var ctx = new EntityConnector())
            {
                ctx.Configuration.LazyLoadingEnabled = false;

                var stud = (from st in ctx.Students
                            where st.FirstMidName == "Pelle"
                            select st).FirstOrDefault<Student>();

                Console.WriteLine($"StudentID: {stud.StudentId} Name: {stud.FirstMidName} {stud.LastName}");

                Console.WriteLine("\n*****Explicit Loading*****\n");

                ctx.Entry(stud).Collection(st => st.Enrollments).Load();
                Console.WriteLine($"StudentID: {stud.StudentId} \nName: {stud.FirstMidName} {stud.LastName}");

                foreach (var enr in stud.Enrollments)
                {
                    Console.WriteLine($"CourseID: {enr.CourseId} \nEnrollmentID: {enr.EnrollmentId} \nEnrollmentName: {enr.EnrollmentName}");
                }

                Console.ReadLine();
            }

        }

        private static void AddStudent()
        {
            using (var ctx = new EntityConnector())
            {
                Student stud1 = new Student();
                stud1.FirstMidName = "Pelle";
                stud1.LastName = "Svenson";
                stud1.EnrollmentDate = new DateTime(2015, 10, 10);
                ctx.Students.Add(stud1);

                Student stud2 = new Student();
                stud2.FirstMidName = "Erik";
                stud2.LastName = "Jönson";
                stud2.EnrollmentDate = new DateTime(2016, 12, 20);
                ctx.Students.Add(stud2);

                Student stud3 = new Student();
                stud3.FirstMidName = "Jonas";
                stud3.LastName = "Sheik.khalil";
                stud3.EnrollmentDate = new DateTime(2016, 6, 15);
                ctx.Students.Add(stud3);

                ctx.SaveChanges();
            }

            Console.WriteLine("Students added successfully");
        }

        private static void AddCourse()
        {
            using (var ctx = new EntityConnector())
            {
                Course cour1 = new Course();
                cour1.CourseName = "Entity Framework";
                cour1.Credits = 15;
                ctx.Courses.Add(cour1);

                Course cour2 = new Course();
                cour2.CourseName = "Java";
                cour2.Credits = 30;
                ctx.Courses.Add(cour2);

                Course cour3 = new Course();
                cour3.CourseName = "Objective-C";
                cour3.Credits = 30;
                ctx.Courses.Add(cour3);

                ctx.SaveChanges();
            }

            Console.WriteLine("Courses added successfully");
        }

        private static void AddEnrollment()
        {
            using (var ctx = new EntityConnector())
            {
                Enrollment enr1 = new Enrollment();
                enr1.EnrollmentName = "Asp.Net Development";
                enr1.CourseId = 1;
                enr1.Grade = "Good";
                ctx.Enrollments.Add(enr1);

                Enrollment enr2 = new Enrollment();
                enr2.EnrollmentName = "Android Development";
                enr2.CourseId = 2;
                enr2.Grade = "Awsome";
                ctx.Enrollments.Add(enr2);

                Enrollment enr3 = new Enrollment();
                enr3.EnrollmentName = "iOS Development";
                enr3.CourseId = 3;
                enr3.Grade = "Average";
                ctx.Enrollments.Add(enr3);

                ctx.SaveChanges();
            }

            Console.WriteLine("Enrollments added successfully");
        }
    }
}

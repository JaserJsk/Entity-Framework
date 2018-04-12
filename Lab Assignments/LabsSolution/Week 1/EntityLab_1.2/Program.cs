using EntityLab_1._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_1._2
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                Student student = new Student()
                {
                    FirstName = "Jonas",
                    LastName = "Shik-khalil",
                    StudentBirthDate = DateTime.Now.AddYears(-45)
                };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }

            Console.WriteLine("User Added Complete");
            Console.ReadLine();

        }
    }
}

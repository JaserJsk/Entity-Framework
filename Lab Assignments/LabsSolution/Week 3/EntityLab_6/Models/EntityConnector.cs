using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_6.Models
{
    class EntityConnector : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public EntityConnector() : base("name=DefaultConnection")
        {
            //this.Configuration.LazyLoadingEnabled = false;
        }
    }
}

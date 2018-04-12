using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_6.Models
{
    class Student
    {
        public Student()
        {
            this.Enrollments = new HashSet<Enrollment>();
        }

        /* ---------------------------------------------------------- */
        /* COLUMNS */
        /* ---------------------------------------------------------- */
        #region StudentId
        //[Key]
        //[Required]
        public int StudentId { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region LastName
        //[Required]
        //[StringLength(50)]
        public string LastName { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region FirstMidName
        //[Required]
        //[StringLength(50)]
        public string FirstMidName { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region EnrollmentDate
        //[Required]
        public DateTime EnrollmentDate { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        /* RELATIONSHIPS */
        /* ---------------------------------------------------------- */
        #region One-To-Meny Relationship [Enrollments]
        public ICollection<Enrollment> Enrollments { get; set; }
        #endregion
    }

}

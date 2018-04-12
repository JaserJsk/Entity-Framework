using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_6.Models
{
    class Enrollment
    {
        /* ---------------------------------------------------------- */
        /* COLUMNS */
        /* ---------------------------------------------------------- */
        #region EnrollmentID
        //[Key]
        //[Required]
        public int EnrollmentId { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region EnrollmentName
        //[Required]
        //[StringLength(50)]
        public string EnrollmentName { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region CourseID
        //[Key]
        //[Required]
        public int CourseId { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Grade
        //[Required]
        //[StringLength(50)]
        public string Grade { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        /* RELATIONSHIPS */
        /* ---------------------------------------------------------- */

    }

}

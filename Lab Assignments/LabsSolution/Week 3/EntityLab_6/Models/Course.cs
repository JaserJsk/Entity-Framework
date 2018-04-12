using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_6.Models
{
    class Course
    {
        /* ---------------------------------------------------------- */
        /* COLUMNS */
        /* ---------------------------------------------------------- */
        #region CourseID
        //[Key]
        //[Required]
        public int CourseId { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region CourseName
        //[Required]
        //[StringLength(50)]
        public string CourseName { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Credits
        [Required]
        public int Credits { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        /* RELATIONSHIPS */
        /* ---------------------------------------------------------- */

    }

}

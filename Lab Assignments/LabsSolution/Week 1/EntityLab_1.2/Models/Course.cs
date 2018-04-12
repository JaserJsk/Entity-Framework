using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_1._2.Models
{
    class Course
    {
        /* ---------------------------------------------------------- */
        /* COLUMNS */
        /* ---------------------------------------------------------- */
        #region Id
        [Key]
        [Required]
        public int Id { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Title
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Instructor
        [Required]
        [StringLength(50)]
        public string Instructor { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        /* RELATIONSHIPS */
        /* ---------------------------------------------------------- */

    }

}

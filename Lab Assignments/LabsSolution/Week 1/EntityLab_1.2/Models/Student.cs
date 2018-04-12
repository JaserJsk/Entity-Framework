using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_1._2.Models
{
    class Student
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
        #region FirstName
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region LastName
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region FullName
        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", FirstName, LastName).Trim();
            }
        }
        #endregion

        /* ---------------------------------------------------------- */
        #region StudentBirthDate
        [Required]
        public DateTime StudentBirthDate { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        /* RELATIONSHIPS */
        /* ---------------------------------------------------------- */

    }

}

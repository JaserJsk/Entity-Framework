using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_2._1.Models
{
    class Player
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
        #region Position
        [Required]
        [StringLength(50)]
        public string Position { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Technique
        [Required]
        [StringLength(100)]
        public string Technique { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Number
        [Required]
        public int Number { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region PlayerEnrollmentDate
        [Required]
        public DateTime PlayerEnrollmentDate { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        /* RELATIONSHIPS */
        /* ---------------------------------------------------------- */
        #region Meny To Meny - Meny Players Can Have Meny Games
        public IList<Game> Games { get; set; }
        #endregion

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_2._1.Models
{
    class Game
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
        #region Type
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Strategy
        [Required]
        [StringLength(100)]
        public string Strategy { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region NumberOfPlayers
        [Required]
        public int NumberOfPlayers { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        #region Score
        [Required]
        public int Score { get; set; }
        #endregion

        /* ---------------------------------------------------------- */
        /* RELATIONSHIPS */
        /* ---------------------------------------------------------- */
        #region Meny To Meny - Meny Games Can Have Meny Players
        public IList<Player> Players { get; set; }
        #endregion

    }

}

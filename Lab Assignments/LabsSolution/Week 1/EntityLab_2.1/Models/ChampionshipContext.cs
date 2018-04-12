using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_2._1.Models
{
    class ChampionshipContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DbSet<Game> Games { get; set; }

        public ChampionshipContext() : base("name=DefaultConnection")
        {

        }
    }
}

using EntityLab_2._1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_2._1
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new ChampionshipContext())
            {
                Player player = new Player()
                {
                    FirstName = "Zlatan",
                    LastName = "Ibrahimovic",
                    Position = "Center",
                    Technique = "Dribbler",
                    Number = 10,
                    PlayerEnrollmentDate = DateTime.Now
                };

                ctx.Players.Add(player);
                ctx.SaveChanges();

            }

            Console.WriteLine("User Added Complete");
            Console.ReadLine();

        }
    }
}

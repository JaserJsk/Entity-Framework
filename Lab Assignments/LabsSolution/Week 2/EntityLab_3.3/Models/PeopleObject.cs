using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_3._3.Models
{
    class PeopleObject
    {
        /* ********************************************************************* */
        public void GetAllPeopleCompleteList()
        {
            var allPeople = from pe in CreatePeopleObject()
                            select pe;

            foreach (var peo in allPeople)
            {
                Console.WriteLine(
                    "ID = " + peo.ID +
                    ", FirstName = " + peo.FirstName +
                    ", LastName = " + peo.LastName +
                    ", PhoneNumber = " + peo.PhoneNumber +
                    ", Salery = " + peo.Salery +
                    ", Profession = " + peo.Profession);
            }
        }

        /* ********************************************************************* */
        public void GetAllPeopleInCompleteList()
        {
            var allPeople = from pe in CreatePeopleObject()
                            select new { ID = pe.ID, FirstName = pe.FirstName, LastName = pe.LastName };

            foreach (var peo in allPeople)
            {
                Console.WriteLine(
                    "ID = " + peo.ID + 
                    ", FirstName = " + peo.FirstName + 
                    ", LastName = " + peo.LastName);
            }
        }

        /* ********************************************************************* */
        public void GetAllPeopleByProfession()
        {
            var allPeople = from pe in CreatePeopleObject()
                            where pe.Profession == "Instructor"
                            select new { ID = pe.ID, FirstName = pe.FirstName, Profession = pe.Profession };

            foreach (var peo in allPeople)
            {
                Console.WriteLine(
                    "ID = " + peo.ID +
                    ", FirstName = " + peo.FirstName +
                    ", Profession = " + peo.Profession);
            }
        }

        /* ********************************************************************* */
        public void GetAllPeopleByFirstLetter()
        {
            var allPeople = from pe in CreatePeopleObject()
                            let first = pe.FirstName.Substring(0, 1)
                            orderby first
                            select first.Distinct();

            
        }

        /* ********************************************************************* */
        private List<People> CreatePeopleObject()
        {
            List<People> objPeople = new List<People>();

            objPeople.Add(new People { ID = 1, FirstName = "Mike", LastName = "Archer", PhoneNumber = "+46875215637", Salery = 12500, Profession = "Lawyer" });
            objPeople.Add(new People { ID = 2, FirstName = "Sammy", LastName = "Spears", PhoneNumber = "+46265125962", Salery = 16562, Profession = "Programmer" });
            objPeople.Add(new People { ID = 3, FirstName = "Karen", LastName = "Acker", PhoneNumber = "+46021687512", Salery = 14562, Profession = "Human Resources" });
            objPeople.Add(new People { ID = 4, FirstName = "Alex", LastName = "Reyes", PhoneNumber = "+46548640681", Salery = 15620, Profession = "Teacher" });
            objPeople.Add(new People { ID = 5, FirstName = "Jack", LastName = "Greyson", PhoneNumber = "+46650594621", Salery = 11258, Profession = "Instructor" });
            objPeople.Add(new People { ID = 6, FirstName = "Selma", LastName = "Hazel", PhoneNumber = "+46214580065", Salery = 10256, Profession = "Nurse" });
            objPeople.Add(new People { ID = 7, FirstName = "Sharon", LastName = "Quinn", PhoneNumber = "+46145870239", Salery = 13569, Profession = "Psychiatrist" });
            objPeople.Add(new People { ID = 8, FirstName = "Kevin", LastName = "Ulrich", PhoneNumber = "+46105300955", Salery = 20556, Profession = "Judge" });

            return objPeople;
        }

        /* ********************************************************************* */
        class People
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public int Salery { get; set; }
            public string Profession { get; set; }
        }

    }

}

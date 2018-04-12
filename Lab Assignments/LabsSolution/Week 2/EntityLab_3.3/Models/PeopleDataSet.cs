using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_3._3.Models
{
    /* ********************************************************************* */
    class PeopleDataSet
    {
        public void GetAllPeopleCompleteList()
        {
            DataTable peopleTable = CreatePeopleDataSet().Tables["People"];

            var allPeople = from pe in peopleTable.AsEnumerable()
                            select pe;

            foreach (var peo in allPeople)
            {
                Console.WriteLine(
                    "ID = " + peo[0] +
                    ", FirstName = " + peo[1] +
                    ", LastName = " + peo[2] +
                    ", PhoneNumber = " + peo[3] +
                    ", Salery = " + peo[4] +
                    ", Profession = " + peo[5]);
            }

        }

        /* ********************************************************************* */
        public void GetAllPeopleByProfession()
        {
            DataTable peopleTable = CreatePeopleDataSet().Tables["People"];

            var allPeople = from pe in peopleTable.AsEnumerable()
                            where pe[5].ToString() == "Instructor"
                            select pe;

            foreach (var peo in allPeople)
            {
                Console.WriteLine(
                    "ID = " + peo[0] +
                    ", FirstName = " + peo[1] +
                    ", LastName = " + peo[2] +
                    ", PhoneNumber = " + peo[3] +
                    ", Salery = " + peo[4] +
                    ", Profession = " + peo[5]);
            }

        }

        /* ********************************************************************* */
        public void GetAllPeopleByFirstLetter()
        {
            DataTable peopleTable = CreatePeopleDataSet().Tables["People"];

           

        }

        /* ********************************************************************* */
        private DataSet CreatePeopleDataSet()
        {
            DataTable tab = new DataTable("People");
            tab.Columns.Add("ID");
            tab.Columns.Add("FistName");
            tab.Columns.Add("LastName");
            tab.Columns.Add("PhoneNumber");
            tab.Columns.Add("Salery");
            tab.Columns.Add("Profession");

            tab.Rows.Add(1, "Mike", "Archer", "+46875215637", 12500, "Lawyer" );
            tab.Rows.Add(2, "Sammy", "Spears", "+46265125962", 16562, "Programmer" );
            tab.Rows.Add(3, "Karen", "Acker", "+46021687512", 14562, "Human Resources" );
            tab.Rows.Add(4, "Alex", "Reyes", "+46548640681", 15620, "Teacher" );
            tab.Rows.Add(5, "Jack", "Greyson", "+46650594621", 11258, "Instructor" );
            tab.Rows.Add(6, "Selma", "Hazel", "+46214580065", 10256, "Nurse" );
            tab.Rows.Add(7, "Sharon", "Quinn", "+46145870239", 13569, "Psychiatrist" );
            tab.Rows.Add(8, "Kevin", "Ulrich", "+46105300955", 20556, "Judge" );

            DataSet peopleDataset = new DataSet();
            peopleDataset.Tables.Add(tab);

            return peopleDataset;

        }

    }

}

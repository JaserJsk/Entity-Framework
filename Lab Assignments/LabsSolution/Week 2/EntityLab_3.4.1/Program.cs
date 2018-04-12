using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_3._4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* ********************************************************************* */
            //PeopleObject peObj = new PeopleObject();
            //peObj.GetAllPeopleCompleteList();
            //peObj.GetAllPeopleInCompleteList();
            //peObj.GetAllPeopleByName();
            /* ********************************************************************* */
            //PeopleDataSet peDaset = new PeopleDataSet();
            //peDaset.GetAllPeopleCompleteList();
            //peDaset.GetAllPeopleByProfession();

            /* ********************************************************************* */
            PeopleXML peXml = new PeopleXML();
            //peXml.GetAllPeopleCompleteList();
            peXml.GetAllPeopleByProfession();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EntityLab_3._4._1.Models
{
    class PeopleXML
    {
        /* ********************************************************************* */
        public void GetAllPeopleCompleteList()
        {
            var allPeople = from pe in CreatePeopleXML().Descendants("People")
                            select new { ID = pe.Attribute("ID").Value,
                                FirstName = pe.Element("FirstName").Value,
                                LastName = pe.Element("LastName").Value,
                                PhoneNumber = pe.Element("PhoneNumber").Value,
                                Salery = pe.Element("Salery").Value,
                                Profession = pe.Element("XAttribute").Value };

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
        public void GetAllPeopleByProfession()
        {
            var allPeople = from pe in CreatePeopleXML().Descendants("People")
                            where pe.Element("Profession").Value == "Instructor"
                            select new
                            {
                                ID = pe.Attribute("ID").Value,
                                FirstName = pe.Element("FirstName").Value,
                                LastName = pe.Element("LastName").Value,
                                Profession = pe.Element("Profession").Value
                            };

            foreach (var peo in allPeople)
            {
                Console.WriteLine(
                    "ID = " + peo.ID +
                    ", FirstName = " + peo.FirstName +
                    ", LastName = " + peo.LastName +
                    ", Profession = " + peo.Profession);
            }


        }

        /* ********************************************************************* */
        private XDocument CreatePeopleXML()
        {
            XDocument xml = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Xml Document"),
                new XElement("Peoples",
                    new XElement("People",
                        new XAttribute("ID", 1),
                        new XElement("FirstName", "Mike"),
                        new XElement("LastName", "Archer"),
                        new XElement("PhoneNumber", "+46875215637"),
                        new XElement("Salery", 12500),
                        new XElement("Profession", "Lawyer"))
                        ,
                    new XElement("People",
                        new XAttribute("ID", 2),
                        new XElement("FirstName", "Sammy"),
                        new XElement("LastName", "Spears"),
                        new XElement("PhoneNumber", "+46265125962"),
                        new XElement("Salery", 16562),
                        new XElement("Profession", "Programmer"))
                        ,
                    new XElement("People",
                        new XAttribute("ID", 3),
                        new XElement("FirstName", "Karen"),
                        new XElement("LastName", "Acker"),
                        new XElement("PhoneNumber", "+46021687512"),
                        new XElement("Salery", 14562),
                        new XElement("Profession", "Human Resources"))
                        ,
                    new XElement("People",
                        new XAttribute("ID", 4),
                        new XElement("FirstName", "Alex"),
                        new XElement("LastName", "Reyes"),
                        new XElement("PhoneNumber", "+46548640681"),
                        new XElement("Salery", 15620),
                        new XElement("Profession", "Teacher"))
                        ,
                    new XElement("People",
                        new XAttribute("ID", 5),
                        new XElement("FirstName", "Jack"),
                        new XElement("LastName", "Greyson"),
                        new XElement("PhoneNumber", "+46650594621"),
                        new XElement("Salery", 11258),
                        new XElement("Profession", "Instructor"))
                        ,
                    new XElement("People",
                        new XAttribute("ID", 6),
                        new XElement("FirstName", "Selma"),
                        new XElement("LastName", "Hazel"),
                        new XElement("PhoneNumber", "+46214580065"),
                        new XElement("Salery", 10256),
                        new XElement("Profession", "Nurse"))
                        ,
                    new XElement("People",
                        new XAttribute("ID", 7),
                        new XElement("FirstName", "Sharon"),
                        new XElement("LastName", "Quinn"),
                        new XElement("PhoneNumber", "+46145870239"),
                        new XElement("Salery", 13569),
                        new XElement("Profession", "Psychiatrist"))
                        ,
                    new XElement("People",
                        new XAttribute("ID", 8),
                        new XElement("FirstName", "Kevin"),
                        new XElement("LastName", "Ulrich"),
                        new XElement("PhoneNumber", "+46105300955"),
                        new XElement("Salery", 20556),
                        new XElement("Profession", "Judgeee")))
                
                );


            return xml;

        }

    }

}

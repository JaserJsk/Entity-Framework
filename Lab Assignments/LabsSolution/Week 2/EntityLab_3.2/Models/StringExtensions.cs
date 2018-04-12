using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLab_3._2.Models
{
    class StringExtensions
    {
        public static string StringToFloat(string str)
        {
            float twe = 12F;
            float stringToFloat = Convert.ToSingle(str);

            float combo = stringToFloat * twe;

            string result = combo.ToString();

            return result;
        }

    }
}

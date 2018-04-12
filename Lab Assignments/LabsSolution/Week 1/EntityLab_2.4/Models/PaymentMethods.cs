using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2._4.Models
{
    enum PaymentMethods
    {
        Cash,
        Bank,
        Card,
    }

    class PayMethods
    {
        public PaymentMethods pm { get; set; }
    }
}

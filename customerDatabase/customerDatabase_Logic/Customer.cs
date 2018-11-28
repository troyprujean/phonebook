// Name  : Troy Prujean
// ID    : 9930285
// Date  : 19/10/2018
// Title : Customer Database - Customer Class - COMP.5212 assignment 1B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerDatabase_Logic
{
    public class Customer
    {
        // Auto implemented properties
        public string FName { get; set; }
        public string LName { get; set; }
        public string Phone { get; set; }

        // Constructor for the class properties
        public Customer(string fn, string ln, string ph)
        {
            FName = fn;
            LName = ln;
            Phone = ph;
        }

        // Method to concatenate a string containing first name, last name and phone number
        public string GetCustomer()
        {
            return $"{FName}\t{LName}\t{Phone}";
        }
    }
}

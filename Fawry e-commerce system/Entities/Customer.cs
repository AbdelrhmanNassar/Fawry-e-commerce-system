using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Entities
{
    internal class Customer
    {
        public Customer(string name,string phone,float balance)
        {
            Name = name;
            Phone = phone;
            Balance = balance;
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public float Balance { get; set; }
    }
}

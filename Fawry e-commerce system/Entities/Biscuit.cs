using Fawry_e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Entities
{
    internal class Biscuit : _ProductBase ,IExpirable
    {
        public Biscuit(string Name, float Price, int Quantity) : base(Name, Price, Quantity)
        {

        }
        private DateOnly expirationDate;
        public DateOnly ExpirationDate
        {
            get { return expirationDate; }
            set
            {
                if (value < DateOnly.FromDateTime(DateTime.Now))
                {
                    do
                    {
                        Console.Write("It's Already Expired, Add A valid Expiration Date: ");
                        DateOnly.TryParse(Console.ReadLine(), out expirationDate);
                    } while (expirationDate < DateOnly.FromDateTime(DateTime.Now));
                }
            }
        }

        public bool isExpired() => expirationDate < DateOnly.FromDateTime(DateTime.Now) ? true : false;
    }
}

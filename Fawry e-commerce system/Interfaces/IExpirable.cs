using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Interfaces
{
    internal interface IExpirable
    {
        public DateOnly ExpirationDate { get; set; }

        bool isExpired();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Entities
{
    internal class ScratchCard : _ProductBase
    {
        public ScratchCard(string Name, float Price, int Quantity) : base(Name, Price, Quantity)
        {
        }
    }
}

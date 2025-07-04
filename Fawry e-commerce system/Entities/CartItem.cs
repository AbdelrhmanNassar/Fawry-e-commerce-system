using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Entities
{
    internal class CartItem
    {

        public CartItem(_ProductBase Product,int OrderedQuantity)
        {
            this.Product = Product;
            this.OrderedQuantity = OrderedQuantity;
        }

        public _ProductBase Product { get; }
        public int OrderedQuantity { get; }
    }

}

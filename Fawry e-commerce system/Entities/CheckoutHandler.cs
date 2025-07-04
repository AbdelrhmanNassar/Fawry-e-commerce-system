
using Fawry_e_commerce_system.Interfaces;
using Fawry_e_commerce_system.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Entities
{
    internal static class CheckoutHandler
    {

        public static void Checkout(Customer customer, CartEntity cart)
        {
            if (cart.Cart == null || !cart.Cart.Any())
            {
                Console.WriteLine("Error: Cart is empty.");
                return;
            }
            float totalInvoice = 0;
            float fee = 0;
            var shippingService = new ShippingService();
            var c = cart.Cart;
            List<IShippable> shippables = new List<IShippable>();
            StringBuilder shippmentNotice = new StringBuilder("** Shipment notice **\n");
            StringBuilder TotalInVoice = new StringBuilder("** Checkout receipt **\n");

            foreach (var item in c)
            {
                if (item is IShippable shippable)
                {
                    shippables.Add(shippable);
                    shippmentNotice.Append($"{item.OrderedQuantity}X {item.Product.Name}       {shippable.Weight * item.OrderedQuantity}g\n");
                }

                TotalInVoice.Append($"{item.OrderedQuantity}X {item.Product.Name}       {item.Product.Price * item.OrderedQuantity}\n");
                totalInvoice += item.Product.Price * item.OrderedQuantity;
            }
            fee = shippingService.GetShippingItemsFee(shippables);

            Console.WriteLine(shippmentNotice);
            Console.WriteLine();
            Console.WriteLine(TotalInVoice);
            Console.WriteLine("-----------------");
            Console.WriteLine($"SubTotal : {totalInvoice}");
            Console.WriteLine($"Shipping : {fee}");
            Console.WriteLine($"amount : {totalInvoice+fee}");

            if(totalInvoice + fee > customer.Balance)
            {
                Console.WriteLine("Insufficient balance");
                return;
            }
            else
            {
                customer.Balance -=  totalInvoice + fee;
                Console.WriteLine("Succeed Order!");

            }


        }

    }
}

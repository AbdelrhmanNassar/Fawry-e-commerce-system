using Fawry_e_commerce_system.Entities;

namespace Fawry_e_commerce_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region First Test Case : when all data is good 
            //var customer = new Customer("Abdo", "01151916672", 2000);
            //var cheese = new Cheese("Cheddar Cheese", 100, 5, 0.2f, DateOnly.FromDateTime(DateTime.Now));
            //var tv = new Tv("Samsung TV", 200, 2, 1200f);

            //var cart = new CartEntity();
            //cart.Add(cheese, 2);  // Valid
            //cart.Add(tv, 1);      // Valid

            //     CheckoutHandler.Checkout(customer, cart); 
            #endregion

            #region First Test Case : when in suffiencet balance 
            //var customer = new Customer("Abdo", "01151916672", 20);
            //var cheese = new Cheese("Cheddar Cheese", 100, 5, 0.2f, DateOnly.FromDateTime(DateTime.Now));
            //var tv = new Tv("Samsung TV", 200, 2, 1200f);

            //var cart = new CartEntity();
            //cart.Add(cheese, 2);  // Valid
            //cart.Add(tv, 1);      // Valid

            //CheckoutHandler.Checkout(customer, cart); 
            #endregion

            #region Expired Product
            //var expiredCheese = new Cheese("Expired Cheese", 80, 3, 0.5f,DateOnly.FromDateTime( DateTime.Now.AddDays(-1))); // Should be rejected
            //var customer = new Customer("Sara","01151916672" ,2000);
            //var cart = new CartEntity();
            //cart.Add(expiredCheese, 1); 

            //CheckoutHandler.Checkout(customer, cart); // Should give expired error

            #endregion

            #region  out of Stock
            //var biscuits = new Biscuits("Chocolate Biscuits", 50, 1, DateOnly.FromDateTime( DateTime.Now.AddDays(10)));
            //var customer = new Customer("Ali", "01151916672",2000);
            //var cart = new CartEntity();
            //cart.Add(biscuits, 2); // Requesting 2 but only 1 in stock

            //CheckoutHandler.Checkout(customer, cart); // warnning

            #endregion

            #region Entity is not Shipple or can be Expired like  Scratch Card 
            //var scratchCard = new ScratchCard("Vodafone 100 EGP", 100, 10);
            //var customer = new Customer("Lina", "01151916672",2000);
            //var cart = new CartEntity();
            //cart.Add(scratchCard, 1);  // Valid non-shippable

            //CheckoutHandler.Checkout(customer, cart); // No shipment notice
            #endregion

        }
    }
}

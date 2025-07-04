using Fawry_e_commerce_system.Interfaces;
using System.Reflection.Metadata.Ecma335;

namespace Fawry_e_commerce_system.Entities
{
    internal class CartEntity
    {
        public List<CartItem> Cart = new List<CartItem>();

        public void Add(_ProductBase product, int qunatity)
        {
            if (product != null)
            {
                if (product is IExpirable expirable)
                {
                    if (expirable.isExpired())
                    {
                        
                        Console.WriteLine($"====*****{product.Name} Product Is Expired*****====");
                    }
                    else
                    {
                        checkQuantity(product, qunatity);

                    }
                }
                else
                {
                    checkQuantity( product,  qunatity);
                }


            }
            else
            {
                throw new NullReferenceException("Product Is Null");
            }

        }

        private void checkQuantity(_ProductBase product, int qunatity)
        {
            if (product.Quantity >= qunatity)
            {
                product.Quantity -= qunatity;
                Cart.Add(new CartItem(product, qunatity));
            }
            else
            {
                Console.WriteLine($"======*****Sorry Stock Is empty for {product.Name}*****======");
            }
        }
    }



}

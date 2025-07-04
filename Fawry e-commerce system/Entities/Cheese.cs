using Fawry_e_commerce_system.Interfaces;

namespace Fawry_e_commerce_system.Entities
{
    internal class Cheese : _ProductBase, IShippable,IExpirable
    {
        public Cheese(string Name, float Price, int Quantity, float Weight,DateOnly ExpiredDate) : base(Name, Price, Quantity)
        {
            this.ExpirationDate = ExpiredDate;
        }

        public float weight;
        public float Weight
        {
            get { return weight; }

            set
            {
                if (Weight <= 0)
                {
                    do
                    {
                        Console.WriteLine("Please Enter A Valid Weight In Grams :");
                        float.TryParse(Console.ReadLine(),out weight);

                    } while (weight < 0);
                }
                else
                {
                    Weight = value;
                }
            }
        }

        private DateOnly expirationDate;
        public DateOnly ExpirationDate
        {
            get { return expirationDate; }
            set {
                if (value < DateOnly.FromDateTime(DateTime.Now) )
                {
                    do
                    {
                        Console.Write("It's Already Expired, Add A valid Expiration Date (yyyy-mm-dd): ");
                        DateOnly.TryParse(Console.ReadLine(),out expirationDate);
                    } while (expirationDate < DateOnly.FromDateTime(DateTime.Now));
                }
                else
                {
                    expirationDate = value;
                }

            }
        }

        public bool isExpired() => expirationDate < DateOnly.FromDateTime(DateTime.Now) ? true : false;
    
}
}

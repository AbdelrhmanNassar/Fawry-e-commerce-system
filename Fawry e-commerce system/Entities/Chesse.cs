using Fawry_e_commerce_system.Interfaces;

namespace Fawry_e_commerce_system.Entities
{
    internal class Chesse : _ProductBase, IShippable,IExpirable
    {
        public Chesse(string Name, float Price, int Quantity, float Weight,DateOnly ExpiredDate) : base(Name, Price, Quantity)
        {
            this.ExpirationDate = ExpirationDate;
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
                        Console.Write("It's Already Expired, Add A valid Expiration Date: ");
                        DateOnly.TryParse(Console.ReadLine(),out expirationDate);
                    } while (expirationDate < DateOnly.FromDateTime(DateTime.Now));
                }
            }
        }

        public bool isExpired() => expirationDate < DateOnly.FromDateTime(DateTime.Now) ? true : false;
    
}
}

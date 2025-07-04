using Fawry_e_commerce_system.Interfaces;

namespace Fawry_e_commerce_system.Entities
{
    internal class Meat : _ProductBase, IExpirable
    {
        public Meat(string Name, float Price, int Quantity, DateOnly ExpireDate) : base(Name, Price, Quantity)
        {
            ExpirationDate = ExpireDate;
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

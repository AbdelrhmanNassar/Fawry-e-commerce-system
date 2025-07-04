using System.Windows.Markup;

namespace Fawry_e_commerce_system.Entities
{
    abstract class _ProductBase
    {
        protected _ProductBase(string Name, float Price, int Quantity)
        {
            this.Name = Name;
            this.Price = Price;
            this.Quantity = Quantity;
            this.Name = Name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value is null)
                {
                    do
                    {

                        Console.Write("Please Enter A Valid Name: ");
                        name = Console.ReadLine();
                    } while (name is null);
                }
                else
                {
                    name = value;
                }


            }
        }
        private float price;

        public float Price
        {
            get { return price; }
            set
            {

                if (value <= 0)
                {
                    do
                    {
                        Console.WriteLine("Please Enter A Valid Price \t (Price Should Be More Than Zero):- ");
                        Console.Write("Price: ");
                        float.TryParse(Console.ReadLine(), out price);
                    } while (price <= 0);
                }
                else
                {
                    price = value;
                }
            }
        }

        private int quantity;

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                {
                    do
                    {
                        Console.WriteLine("Please Enter A Valid Quantity \t (Quantity Can not be less than Zero):- ");
                        Console.Write("Quantity: ");
                        int.TryParse(Console.ReadLine(), out quantity);
                    } while (quantity < 0);
                }
                else
                {
                    quantity = value;
                }
            }
        }

    }
}

using Fawry_e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Entities
{
    internal class Tv : _ProductBase , IShippable
    {
        public Tv(string Name, float Price, int Quantity) : base(Name, Price, Quantity)
        {
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
    
    }
}

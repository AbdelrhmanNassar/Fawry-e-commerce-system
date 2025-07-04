using Fawry_e_commerce_system.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_e_commerce_system.Services
{
    internal class ShippingService
    {

        public float GetShippingItemsFee<T>(List<T> items) where T : IShippable
        {
            #region How i calculated Fee
            //it sounds from giving test case 
            //30/1.1 = 27.27 egp/kilo
            #endregion
            float fee = 27.27f;
            float totalWeightInKilo = 0;
            foreach (var item in items) {
                totalWeightInKilo += item.Weight;//in grams
            }
            totalWeightInKilo = totalWeightInKilo / 1000;//in kilo

            return fee * totalWeightInKilo;

        }
    }
}

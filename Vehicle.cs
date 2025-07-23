using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalPolymorephism
{
    class Vehicle
    {
        // Feilds 
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }

        // Apply a discount if rental days > 7   ======= virtual
        public virtual double CalculateRentalCost(int days)
        {
            double cost = 0;
            // Apply discount if rental days > 7
            if (days > 7)
            {
                cost *= 0.90; // 10% discount for rentals longer than 7 days [cite: 32]
            }
            return cost;
        }

       
    }
}

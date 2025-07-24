using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalPolymorephism
{
    class Vehicle
    {
        // Feilds 
        public string Brand { get; set; }
        public string Model { get; set; }
        private int year;
        public string LicensePlate { get; set; }

        public int Year
        {
            get {  return year; }
            set 
            { if (value < 2010) 
                {
                    Console.WriteLine("Error Input; year can not be less than 2010");
                }
                else
                {
                    year = value;
                }
            }
        }

        // Calculate Rental Cost   ======= virtual
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

        // Calculate Rental Cost ================= Overloading
        public double CalculateRentalCost(int days, bool withDriver)
        {
         


        double baseCost = CalculateRentalCost(days);
            if (withDriver)
            {
                return baseCost + (days * 50); 
            }
            return baseCost;

        }

        // Constructor for Vehicle
        public Vehicle(string brand, string model, int year, string licensePlate)
        {
            Brand = brand;
            Model = model;
            Year = year; // Use the property to apply the validation logic
            LicensePlate = licensePlate;
        }
    }

    class Car : Vehicle 
    { 
        public bool IsLuxury { get; set; }

        // Override CalculateRentalCost(int days)
        public override double CalculateRentalCost(int days)
        {
            double cost = 0;
            if (IsLuxury == true)
            {
                // Apply discount if rental days > 7
                if (days > 7)
                {
                    cost *= 0.80; // 10% discount for rentals longer than 7 days [cite: 32]
                }
            }
            else
            {
                if (IsLuxury == false)
                {
                    // Apply discount if rental days > 7
                    if (days > 7)
                    {
                        cost *= 0.60; // 10% discount for rentals longer than 7 days [cite: 32]
                    }
                }
            }
            return cost;

        }

        // Overload method for CalculateRentalCost with driver for Car
        public double CalculateRentalCost(int days, bool withDriver)
        {

            double baseCost = CalculateRentalCost(days);
            if (withDriver)
            {
                return baseCost + (days * 70);
            }
            return baseCost;

        }

        // constructor

    }

    class Truck: Vehicle
    {
        public double MaxLoadKg;

        // Override CalculateRentalCost(int days)
        public virtual double CalculateRentalCost(int days)
        {
            double cost = 0;
            // Apply discount if rental days > 7
            if (days > 7)
            {
                cost *= 1.0; // 10% discount for rentals longer than 7 days [cite: 32]
            }
            return cost;
        }

        // Overload method for CalculateRentalCost with driver for Car
        public new double CalculateRentalCost(int days, double cargoWeight)
        {
            double MaxLoadKg = 100.00;

            double baseCost = CalculateRentalCost(days);
            if (cargoWeight<= MaxLoadKg)
            {
                baseCost = baseCost + (days * 70);
            }
            else
            {
                baseCost = baseCost + (days * 90);
            }
             
            return baseCost;

        }

    }

    class Motorbike : Vehicle 
    {
        bool RequiresHelmet = false;

        // Calculate Rental Cost overload for Motorbike
        public virtual double CalculateRentalCost(int days)
        {
            double cost = 0;
            // Apply discount if rental days > 7
            if (days > 7)
            {
                cost *= 0.40; // 10% discount for rentals longer than 7 days [cite: 32]
            }
            return cost;
        }

    }
}

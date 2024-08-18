using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inheritance
{
    public class ElectricCar : Car
    {
        private double batteryLevel;

        public ElectricCar(string brand, string model, int year) : base(brand, model, year)
        {
            batteryLevel = 100.0; // Default battery level is 100%
        }

        public void ChargeBattery(double amount)
        {
            batteryLevel += amount;
            if (batteryLevel > 100.0)
            {
                batteryLevel = 100.0;
            }
            Console.WriteLine($"Battery charged to {batteryLevel}%.");
        }

        // Overriding the Drive method (Polymorphism)
        public new void Drive(double distance)
        {
            double batteryConsumed = distance * 0.2;  // Assume 5 km per 1% of battery
            if (batteryConsumed <= batteryLevel)
            {
                batteryLevel -= batteryConsumed;
                Console.WriteLine($"You drove {distance} km. Battery level: {batteryLevel}%.");
            }
            else
            {
                Console.WriteLine("Not enough battery to drive the distance.");
            }
        } 


    }
}

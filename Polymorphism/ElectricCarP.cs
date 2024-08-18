using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class ElectricCarP : CarP
    {
        private double batteryLevel;
        public ElectricCarP(string brand, string model, int year) : base(brand, model, year)
        {
            batteryLevel = 100.0;
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
        // Overriding and overloading the Drive method (Polymorphism)
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

        // Overloaded Drive method that also takes speed into account
        public void Drive(double distance, double speed)
        {
            double batteryConsumed = (distance * 0.2) * (speed / 100.0);  // More speed consumes more battery
            if (batteryConsumed <= batteryLevel)
            {
                batteryLevel -= batteryConsumed;
                Console.WriteLine($"You drove {distance} km at {speed} km/h. Battery level: {batteryLevel}%.");
            }
            else
            {
                Console.WriteLine("Not enough battery to drive the distance at that speed.");
            }
        }
    }
}

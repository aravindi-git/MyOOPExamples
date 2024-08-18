namespace Polymorphism
{
    public class CarP
    {
        private string brand;
        private string model;
        private int year;
        private double fuelLevel;

        public CarP(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.fuelLevel = 100.0;
        }

        public void Drive(double distance)
        {
            double fuelConsumed = distance * 0.1;  // Assume 10 km per 1% of fuel
            if (fuelConsumed <= fuelLevel)
            {
                fuelLevel -= fuelConsumed;
                Console.WriteLine($"You drove {distance} km. Fuel level: {fuelLevel}%.");
            }
            else
            {
                Console.WriteLine("Not enough fuel to drive the distance.");
            }
        }

        // Overloaded Drive method that also takes speed into account
        public void Drive(double distance, double speed)
        {
            double fuelConsumed = (distance * 0.1) * (speed / 100.0);  // More speed consumes more fuel
            if (fuelConsumed <= fuelLevel)
            {
                fuelLevel -= fuelConsumed;
                Console.WriteLine($"You drove {distance} km at {speed} km/h. Fuel level: {fuelLevel}%.");
            }
            else
            {
                Console.WriteLine("Not enough fuel to drive the distance at that speed.");
            }
        }

        public void Refuel(double amount)
        {
            fuelLevel += amount;
            if (fuelLevel > 100.0)
            {
                fuelLevel = 100.0;
            }
            Console.WriteLine($"Refueled to {fuelLevel}%.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {year} {brand} {model}");
        }
    }
}


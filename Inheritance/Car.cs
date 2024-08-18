namespace Inheritance
{
    public class Car
    {

        private string brand;
        private string model;
        private int year;
        private double fuelLevel;

        public Car(string brand, string model, int year)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;

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

        public void Refuel(double amount)
        {
            fuelLevel += amount;
            if (fuelLevel > 100.0)
            {
                fuelLevel = 100.0;
            }
            Console.WriteLine($"Refueled to {fuelLevel}%.");
        }

        // Method to display car details
        public void DisplayInfo()
        {
            Console.WriteLine($"Car: {brand} {model} {year} ");
        }
    }
}

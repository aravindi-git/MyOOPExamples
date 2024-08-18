// See https://aka.ms/new-console-template for more information
using Abstraction;
using Inheritance;
using Polymorphism;


Console.WriteLine("===================================Inheritance examples ================================================================");

Car myCar = new Car("Toyota", "Corolla", 2020);

myCar.DisplayInfo();
myCar.Drive(50);
myCar.Refuel(20);
myCar.Drive(100);

ElectricCar myElectricCar = new ElectricCar("Tesla" , "Model C", 2022);

myElectricCar.DisplayInfo();
myElectricCar.ChargeBattery(80);
myElectricCar.Drive(100);


Console.WriteLine("===============================Abstraction Examples====================================================================");

SavingAccount mySavingsAccount = new SavingAccount("12345", "John Doe");
mySavingsAccount.Deposit(1000);
mySavingsAccount.CalculateInterest();
mySavingsAccount.Withdraw(50);

TermAccount termAccount = new TermAccount("45678", "Anne Forester", DateTime.Now.AddDays(-15));
termAccount.Deposit(2000);
termAccount.CalculateInterest();
termAccount.Withdraw(100);
termAccount.CalculateRenewalDate();


Console.WriteLine("===============================Ploymorphism Examples====================================================================");

CarP myCar2 = new CarP("Toyota", "Corolla", 2020);
myCar2.DisplayInfo();
myCar2.Drive(50);
myCar2.Drive(50, 120);  // Using the overloaded method
myCar2.Refuel(20);

// Creating an object of the ElectricCar class
ElectricCarP myElectricCar2 = new ElectricCarP("Tesla", "Model 3", 2022);
myElectricCar2.DisplayInfo();
myElectricCar2.Drive(50);
myElectricCar2.Drive(50, 120);  // Using the overloaded method
myElectricCar2.ChargeBattery(30);









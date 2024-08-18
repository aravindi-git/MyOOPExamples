Here's a simple example of how you can use Object-Oriented Programming (OOP) concepts in C# to model a real-world scenario, such as a car. We'll cover the main OOP concepts: classes, objects, inheritance, encapsulation, polymorphism, and abstraction.

A class is a blueprint for creating objects. An object is an instance of a class.

1. Inheritance allows one class to inherit fields and methods from another class
2. Encapsulation means hiding the internal state of an object and requiring all interactions to be performed through an object's methods. This is achieved by making the fields private and providing public methods to access them.
3. Abstraction simplifies complex reality by modeling classes appropriate to the problem.
4. Polymorphism allows methods to do different things based on the object they are acting upon. In the ElectricCar class, we override the Drive method to behave differently than the Drive method in the Car class.
To extend the polymorphism example with method overloading, we can add multiple Drive methods in the Car and ElectricCar classes. Method overloading allows you to define multiple methods with the same name but different parameters.

Method Overloading: The Drive method in both Car and ElectricCar classes have been overloaded. There are now two Drive methods:

Drive(double distance): This method takes only the distance as a parameter.
Drive(double distance, double speed): This overloaded method takes both distance and speed as parameters. The speed is used to modify how much fuel or battery is consumed.

Method Overriding: The ElectricCar class overrides the Drive method from the Car class and provides its own implementation. It also overloads the Drive method to handle speed as an additional parameter, similar to the Car class.
Usage: In the Main method, both versions of the Drive method are called to demonstrate method overloading.

This example showcases both polymorphism (through method overriding) and method overloading in a real-world scenario.

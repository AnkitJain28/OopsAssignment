using System;

public abstract class Vehicle
{
    public string registrationNumber;
    public string manufacturer;
    public string modelName;

    public abstract void PrintDetails();
}

public class Car : Vehicle 
{
    public Car(string registrationNumber, string manufacturer, string modelName)
    {
        this.registrationNumber = registrationNumber;
        this.manufacturer = manufacturer;
        this.modelName = modelName;
    }

    public override void PrintDetails()
    {
        Console.WriteLine("RegistrationNumber = "+this.registrationNumber);
        Console.WriteLine("Manufacturer = " + this.manufacturer);
        Console.WriteLine("ModelName = "+ this.modelName);
    }
} 

public class Truck : Vehicle
{
    public Truck(string registrationNumber, string manufacturer, string modelName)
    {
        this.registrationNumber = registrationNumber;
        this.manufacturer = manufacturer;
        this.modelName = modelName;
    }

    public override void PrintDetails()
    {
        Console.WriteLine("RegistrationNumber = " + this.registrationNumber);
        Console.WriteLine("Manufacturer = " + this.manufacturer);
        Console.WriteLine("ModelName = " + this.modelName);
    }
}

public class Bus : Vehicle
{
    public Bus(string registrationNumber, string manufacturer, string modelName)
    {
        this.registrationNumber = registrationNumber;
        this.manufacturer = manufacturer;
        this.modelName = modelName;
    }

    public override void PrintDetails()
    {
        Console.WriteLine("RegistrationNumber = " + this.registrationNumber);
        Console.WriteLine("Manufacturer = " + this.manufacturer);
        Console.WriteLine("ModelName = " + this.modelName);
    }
}

class Abstraction
{
    public static void Main(string[] args)
    {
        Car C1 = new Car("RJ12", "Suzuki", "Brezza");
        Truck T1 = new Truck("RJ12", "Tata", "Prima");
        Bus B1 = new Bus("RJ12", "Volvo", "B5L S-Charge");
        C1.PrintDetails();
        T1.PrintDetails();
        B1.PrintDetails();
    }

}
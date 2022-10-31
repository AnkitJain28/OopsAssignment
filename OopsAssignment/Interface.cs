using System;
interface Ifruit
{
    public void PrintDetails();
}

class Apple : Ifruit
{
    public string name = "Apple";
    public string colour = "Red";
    public void PrintDetails()
    {
        Console.WriteLine("Name = "+ this.name);
        Console.WriteLine("colour = "+ this.colour);
    }
}

class Banana : Ifruit
{
    public string name = "Banana";
    public string colour = "Yellow";
    public void PrintDetails()
    {
        Console.WriteLine("Name = " + this.name);
        Console.WriteLine("colour = " + this.colour);
    }
}

class Grapes : Ifruit
{
    public string name = "Grapes";
    public string colour = "Green";
    public void PrintDetails()
    {
        Console.WriteLine("Name = " + this.name);
        Console.WriteLine("colour = " + this.colour);
    }
}

class Interface
{
    public static void Main(string[] args)
    {
        Apple A1 = new Apple();
        Banana B1 = new Banana();
        Grapes G1 = new Grapes();
        A1.PrintDetails();
        B1.PrintDetails();
        G1.PrintDetails();
    }
}
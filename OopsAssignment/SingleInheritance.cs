using System;

class GrandFather
{
    public static string LastName = "Jain";
} 

class Father : GrandFather
{
    public void PrintLastName()
    {
        Console.WriteLine("Lastname = " + LastName);
    }
}
class SingleInheritance
{
    public static void Main(string[] args)
    {
        Father F1 = new Father();
        F1.PrintLastName();
    }
}
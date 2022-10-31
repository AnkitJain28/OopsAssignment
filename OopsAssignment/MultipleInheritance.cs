using System;
interface IAnimal
{
    public void Sound();
}

interface IBird
{
    public void Sound();
}

class Bat : IAnimal, IBird
{
    public void Sound()
    {
        Console.WriteLine(" Bat sound is Ultrasonic");
    }
}

class MultipleInheritance
{
    public static void Main(string[] args)
    {
        Bat  B1 = new Bat();
        B1.Sound();
    }
}
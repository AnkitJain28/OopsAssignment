// See https://aka.ms/new-console-template for more information
using System;
abstract class Shape 
{
    public double area;
    public abstract double CalculateArea();

}

class Circle:Shape
{
    public double radius;
    public override double CalculateArea()
    {
        return Math.PI*radius*radius;
    }
    public Circle(double radius)
    {
        this.radius = radius;
        this.area = this.CalculateArea();
    }
}

class Square:Shape
{
    double edge;
    public  override double CalculateArea() 
    {
        return edge * edge;
    }
    public Square(double edge)
    {
        this.edge = edge;
        this.area = this.CalculateArea();
    }
}

class Rectangle:Shape
{
    double length, breadth;
    public override double CalculateArea()
    {
        return length * breadth;
    }
    public Rectangle(double length,double breadth)
    {
        this.length = length;
        this.breadth = breadth;
        this.area = this.CalculateArea();
    }
}
class DynamicPolymorphism
{

    public static void Main(string[] args)
    {
        Circle C1 = new Circle(5.0);
        Square S1 = new Square(7.0);
        Rectangle R1 = new Rectangle(5.0, 7.0);
        Console.WriteLine("Area of circle C1 is " + C1.area);
        Console.WriteLine("Area of Square S1 is " + S1.area);
        Console.WriteLine("Area of Rectangle R1 is " + R1.area);
        
    }
}
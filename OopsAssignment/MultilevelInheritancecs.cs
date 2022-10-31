using System;

class Son1 : Father
{
    
}

class MultilevelInheritance
{
    public static void Main(string[] args)
    {
        Son1 S1 = new Son1();
        S1.PrintLastName();
    }
}
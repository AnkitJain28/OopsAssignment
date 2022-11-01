using System;

class Methods
{
    public static void Type1()
    {
        Console.WriteLine("Public Method");

    }
    private static void Type2()
    {
        Console.WriteLine("Private Method");
    }

    protected static void Type3()
    {
        Console.WriteLine("Protected Method");

    }
    internal static void Type4()
    {
        Console.WriteLine("Internal Method");

    }

}

class Encapsulation : Methods
{
    public static void Main(string[] args)
    {
        Methods.Type1();
        // Methods.Type2(); Not Accessible as protected. Throws error
        Methods.Type3();
        Methods.Type4();
      
        
       
    }
}


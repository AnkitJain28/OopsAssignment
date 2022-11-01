using System;

class Methods
{
    public void Type1()
    {
        Console.WriteLine("Public Method");

    }
    private void Type2()
    {
        Console.WriteLine("Private Method");
    }

    protected void Type3()
    {
        Console.WriteLine("Protected Method");

    }
    internal void Type4()
    {
        Console.WriteLine("Internal Method");

    }

}
class Derived : Methods
{

}


using System;


class Son2 : Father
{

}
class Daughter1 : Father
{

}
class HierarchicalInheritance
{
    public static void Main(string[] args)
    {
        Son2 S2 = new Son2();
        Daughter1 D1 = new Daughter1();
        S2.PrintLastName();
        D1.PrintLastName();

    }
}
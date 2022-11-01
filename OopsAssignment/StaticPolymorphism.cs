using System;
class User
{
    public string firstName;
    public string lastName;
    public string email;
    public string city;
    public string mobileNumber;
    
    public User(string firstName,string lastName,string email,string city,string mobileNumber)
    {
        this.firstName = firstName;
        this.lastName = lastName;  
        this.email = email;
        this.city = city;
        this.mobileNumber = mobileNumber;
    }
    
    public void Print(int i)
    {
        Console.WriteLine("First Name = " + this.firstName);
        Console.WriteLine("Last Name = " + this.lastName);

    }
    public void Print(double d)
    {
        Console.WriteLine("Email = " + this.email);
        Console.WriteLine("City = " + this.city);
        Console.WriteLine("Mobile Number = " + this.mobileNumber);
    }

}

class StaticPolymorphism
{
    public static void Main(string[] args)
    {

        User U1 = new User("Ankit", "Jain", "aj4451999", "Dungarpur", "9636756942");
        U1.Print(1);
        U1.Print(1.0);

    }
    
} 
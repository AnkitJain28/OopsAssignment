using System;
class Student
{
    public string RollNumber;
    public string Name;
    public Student(string rollNumber, string name)
    {
        RollNumber = rollNumber;
        Name = name;
    }
}

class Course
{
    public string CourseName;
    public int CourseId;
}

class Constructor
{
    public static void Main(string[] args)
    {
        Student S1 = new Student("18BCP006","Ankit Jain");
        Course C1 = new Course();
        

    }
}
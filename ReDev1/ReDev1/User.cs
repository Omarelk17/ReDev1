using System;

public class User
{
    private string name;
    private int age;
    private string hobby;

    // Constructor
    public User(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Method to display user's name and age
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + name + ", Age: " + age);
    }

    // Overloaded method to display user's name, age, and hobby
    public void DisplayInfoWithHobby(string hobby)
    {
        this.hobby = hobby;
        Console.WriteLine("Name: " + name + ", Age: " + age + ", Hobby: " + hobby);
    }

    // Overloaded method to display years until retirement
    public void DisplayYearsUntilRetirement(int yearsUntilRetirement)
    {
        Console.WriteLine(name + " will retire in " + yearsUntilRetirement + " years.");
    }
}

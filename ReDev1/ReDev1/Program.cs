using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user for their name and age
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        // Create an instance of User
        User user = new User(name, age);

        // Display user info without hobby
        user.DisplayInfo();

        // Prompt user for their hobby
        Console.Write("Enter your hobby: ");
        string hobby = Console.ReadLine();

        // Display user info with hobby
        user.DisplayInfoWithHobby(hobby);

        // Calculate years until retirement
        int retirementAge = 65;
        int yearsUntilRetirement = retirementAge - age;

        // Display years until retirement
        user.DisplayYearsUntilRetirement(yearsUntilRetirement);

        // Prevent the console from closing immediately
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();  // Keeps the console open until you press Enter
    }
}

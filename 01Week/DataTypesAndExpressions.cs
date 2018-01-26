using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        bool isHuman = true;

        bool f = false;

        decimal num = 9.99m;

        decimal total = num * num;

        string firstName = "Zemiri";
        string lastName = "Rangel";
        int age = 20;
        string job = "Music Producer";
        string favoriteBand = "Coheed and Cambria";
        string favoriteSportsTeam = "Spurs";

        Console.WriteLine("First Name: " + firstName);
        Console.WriteLine("Last Name: " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Job: " + job);
        Console.WriteLine("Favorite Band: " + favoriteBand);
        Console.WriteLine("Favorite Sports Team: " + favoriteSportsTeam);

        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }
}

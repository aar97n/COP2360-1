using System;

public class Program
{
    public static void Main()
    {
        // Creating instances of Wine using different constructors
        var wine1 = new Wine(50.75m);
        var wine2 = new Wine(75.30m, 2018);

        Console.WriteLine($"Wine 1: Price = {wine1.Price}, Year = {wine1.Year}");
        Console.WriteLine($"Wine 2: Price = {wine2.Price}, Year = {wine2.Year}");

        // Accessing the nested Vineyard class
        Wine.Vineyard vineyard = new Wine.Vineyard("Napa Valley", "California");
        vineyard.PrintDetails();
    }
}

public class Wine
{
    // Fields to hold information about the Wine
    public decimal Price; // Represents the price of the wine
    public int Year;      // Represents the year the wine was produced

    // Constructor Overloading
    // Constructor that accepts only the price
    public Wine(decimal price) => Price = price;

    // Constructor that accepts both price and year, and calls the first constructor using "this"
    public Wine(decimal price, int year) : this(price) => Year = year;

    // Nested Class
    public class Vineyard
    {
        // Properties to hold information about the Vineyard
        public string Name { get; set; }      // The name of the vineyard
        public string Location { get; set; }  // The location of the vineyard

        // Constructor for initializing the Vineyard class
        public Vineyard(string name, string location)
        {
            Name = name;
            Location = location;
        }

        // Method to print details about the vineyard
        public void PrintDetails()
        {
            Console.WriteLine($"Vineyard: {Name}, Location: {Location}");
        }
    }
}

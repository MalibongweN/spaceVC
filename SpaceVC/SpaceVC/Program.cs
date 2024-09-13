using SpaceVC;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        
        CustomArray<Spaceship> spaceshipFleet = new CustomArray<Spaceship>();

        bool continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("\nOptions:");
            Console.WriteLine("1. Add a spaceship");
            Console.WriteLine("2. Search for a spaceship");
            Console.WriteLine("3. Remove a spaceship");
            Console.WriteLine("4. Display all spaceships");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    
                    AddSpaceship(spaceshipFleet);
                    break;
                case 2:
                 
                    SearchSpaceship(spaceshipFleet);
                    break;
                case 3:
                   
                    RemoveSpaceship(spaceshipFleet);
                    break;
                case 4:
                   
                    Console.WriteLine("\nAll Spaceships in the Fleet:");
                    spaceshipFleet.Display();
                    break;
                case 5:
                    
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select again.");
                    break;
            }
        }
    }

    private static void AddSpaceship(CustomArray<Spaceship> fleet)
    {
        Console.WriteLine("\nEnter the spaceship details:");

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Model: ");
        string model = Console.ReadLine();

        Console.Write("Crew Capacity: ");
        int crewCapacity = int.Parse(Console.ReadLine());

        Console.Write("Max Speed: ");
        int maxSpeed = int.Parse(Console.ReadLine());

        Console.Write("Status (Active/Inactive/Maintenance): ");
        string status = Console.ReadLine();

        Console.Write("Launch Date (yyyy-mm-dd): ");
        DateTime launchDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Mission Type (Research/Transport/Military/Communications): ");
        string missionType = Console.ReadLine();

        fleet.Add(new Spaceship(name, model, crewCapacity, maxSpeed, status, launchDate, missionType));
        Console.WriteLine("Spaceship added successfully.");
    }

    private static void SearchSpaceship(CustomArray<Spaceship> fleet)
    {
        Console.Write("\nEnter the name of the spaceship to search: ");
        string name = Console.ReadLine();

        for (int i = 0; i < fleet.Size(); i++)
        {
            if (fleet.GetAt(i).Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Spaceship found at index {i}: {fleet.GetAt(i)}");
                return;
            }
        }
        Console.WriteLine("Spaceship not found.");
    }

    private static void RemoveSpaceship(CustomArray<Spaceship> fleet)
    {
        Console.Write("\nEnter the name of the spaceship to remove: ");
        string name = Console.ReadLine();

        for (int i = 0; i < fleet.Size(); i++)
        {
            if (fleet.GetAt(i).Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                fleet.RemoveAt(i);
                Console.WriteLine("Spaceship removed successfully.");
                return;
            }
        }
        Console.WriteLine("Spaceship not found.");
    }
}

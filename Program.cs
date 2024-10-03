using System;
using SplashKitSDK;

namespace task3week1
{
    public class Program
    {   

        public static void LoadAll(Resource[] resources)
        {

            foreach (var resource in resources)
            {
                Console.WriteLine($"ID: {resource.ID}");
                Console.WriteLine($"Status: {resource.Status}");
                Console.WriteLine($"DateTime Needed: {resource.DateTimeNeeded}");
                Console.WriteLine(resource.Load() + "\n");
            }
        }

        public static void Main()
        {
            Resource[] resources = new Resource[4]; 
            
            resources[0] = new Worker("W600", true, new DateTime(2024, 12, 10, 8, 10, 10), 10, 10);
            resources[1] = new Document("D700", false, new DateTime(2024, 4, 1, 9, 30, 15), "Subject", 
                new DateTime(2023, 11, 3, 10, 15, 0));
            resources[2] = new Vehicle("V800", true, new DateTime(2023, 8, 12, 8, 10, 10));
            resources[3] = new Product("P100", true, new DateTime(2024, 11, 3, 10, 15, 0)); 

            LoadAll(resources);

        }

    }
}

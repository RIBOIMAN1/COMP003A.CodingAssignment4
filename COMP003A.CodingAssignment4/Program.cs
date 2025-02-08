// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int items;
            int dataStorageType;
            int inventoryManagement;
            string productName;
            int productQuantity;
            List<string> allProductNames = new List<string>();
            List<int> allProductQuantities = new List<int>();

            Console.WriteLine("Welcome to the Inventory Management System!");

            Console.WriteLine("\nInventory Management System Menu:");
            Console.WriteLine("1. Add a Product");
            Console.WriteLine("2. Update Product Quantity");
            Console.WriteLine("3. View Inventory Summary");
            Console.WriteLine("4. Exit");
            while (true)
            {
                try
                {
                    Console.Write("Enter your choice: ");
                    inventoryManagement = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("You must choose between choices 1 and 4, try again");
                    continue;
                }
                if (inventoryManagement == 1)
                {
                    try
                    {
                        Console.Write("Enter product name: ");
                        productName = Console.ReadLine();
                        allProductNames.Add(productName);
                        Console.Write("Enter product quantity: ");
                        productQuantity = int.Parse(Console.ReadLine());
                        allProductQuantities.Add(productQuantity);
                        Console.WriteLine("Product added successfully!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unable to add product, try again.");
                    }
                }
                else if (inventoryManagement == 2)
                {
                    try
                    {
                        Console.Write("What product do you want to update the quantity of? ");
                        productName = Console.ReadLine();
                        int index = allProductNames.IndexOf(productName);
                        if (index != -1)
                        {
                            Console.Write("What is your new quantity? ");
                            productQuantity = int.Parse(Console.ReadLine());
                            allProductQuantities[index] = productQuantity;
                            Console.WriteLine("Product quantity updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Product not found.");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unable to update product quantity, try again.");
                    }
                }
                else if (inventoryManagement == 3)
                {
                    try
                    {
                        Console.WriteLine("\nInventory summary: ");
                        for (int i = 0; i < allProductNames.Count; i++)
                        {
                            Console.WriteLine($"- {allProductNames[i]}: {allProductQuantities[i]}");
                        }
                        Console.WriteLine($"Total Products: {allProductNames.Count}");
                        Console.WriteLine($"Total Quantity: {allProductQuantities.Sum()}");
                        Console.WriteLine($"Average Quantity: {allProductQuantities.Average():F2}");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unable to show display summary, try again.");
                    }
                }
                else if (inventoryManagement == 4)
                {
                    Console.WriteLine("\nGoodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("You must choose between choices 1 and 4, try again");
                }
            }
        }
    }
}
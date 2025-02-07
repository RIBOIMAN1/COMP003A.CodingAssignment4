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
			int totalProducts = allProductQuantities.Sum();

			Console.WriteLine("Welcome to the Inventory Management System!");
            while (true)
            {
                try
                {
                    Console.Write("Choose data storage type: ");
                    items = int.Parse(Console.ReadLine());
                    if (items != 1 && items != 2)
                    {
                        Console.WriteLine("This is not a valid input. Try again!");
                    }
                    else if (items == 1)
                    {
                        Console.WriteLine("Sorry, I didn't use arrays in this code. Please select choice 2.");
                    }
                    else
                    {
                        Console.WriteLine("\nInventory Management System Menu:");
                        Console.WriteLine("1. Add a Product");
                        Console.WriteLine("2. Update Product Quantity");
                        Console.WriteLine("3. View Inventory Summary");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter your choice: ");
                        inventoryManagement = int.Parse(Console.ReadLine());
                        if (inventoryManagement == 1)
                        {
                            Console.Write("Enter product name: ");
                            productName = Console.ReadLine();
                            allProductNames.Add(productName);
                            Console.Write("Enter product quantity: ");
                            productQuantity = int.Parse(Console.ReadLine());
                            allProductQuantities.Add(productQuantity);
                            Console.WriteLine("Product added successfully!");
                        }
                        else if (inventoryManagement == 2)
                        {
                            Console.Write("What product do you want to update the quantity of? ");
                            productName = Console.ReadLine();
							int index = allProductNames.IndexOf(productName);
							if (index != -1)
							{
								allProductQuantities[index] = 100;
							}
							else
							{
								Console.WriteLine("Product not found.");
							}
							Console.Write("What is your new quantity? ");
							productQuantity = int.Parse(Console.ReadLine());
							allProductQuantities.Add(productQuantity);
							Console.WriteLine("Product quantity updated successfully!\n");
                        }
                        else if (inventoryManagement == 3)
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
                        else if (inventoryManagement == 4)
                        {
                            Console.WriteLine("Goodbye!");
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
// Author: Riley Benson
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Inventory management application with a minimum of 10 elements in the collection.

namespace COMP003A.CodingAssignment4
{
    internal class Program
    {
        static List<string> allProductNames = new List<string>();
		static List<int> allProductQuantities = new List<int>();
		static bool runProgram = true;
		static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management System!");
            while (runProgram)
            {
                Menu();
                int inventoryManagement = inventoryChoice();
                menuChoice(inventoryManagement);
            }
        }
                static void Menu()
                {
                    Console.WriteLine("\nInventory Management System Menu:");
                    Console.WriteLine("1. Add a Product");
                    Console.WriteLine("2. Update Product Quantity");
                    Console.WriteLine("3. View Inventory Summary");
                    Console.WriteLine("4. Exit");
                }
            static int inventoryChoice()
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Enter your choice: ");
                        return int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("You must choose between choices 1 and 4, try again.");
                    }
                }
            }
        static void menuChoice(int inventoryManagement)
        {
            if (inventoryManagement == 1)
            {
                choice1();
            }
            else if (inventoryManagement == 2)
            {
                choice2();
            }
            else if (inventoryManagement == 3)
            {
                choice3();
            }
            else if (inventoryManagement == 4)
            {
                Console.WriteLine("\nGoodbye!");
                runProgram = false;
			}
            else
            {
                Console.WriteLine("You must choose between choices 1 and 4, try again.");
			}
            static void choice1()
            {
                try
                {
                    Console.Write("\nEnter product name: ");
                    string productName = Console.ReadLine();
                    allProductNames.Add(productName);
                    Console.Write("Enter product quantity: ");
                    int productQuantity = int.Parse(Console.ReadLine());
                    allProductQuantities.Add(productQuantity);
                    Console.WriteLine("Product added successfully!");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to add product, try again.");
                }
            }
            static void choice2()
            {
				try
				{
					Console.Write("\nWhat product do you want to update the quantity of? ");
					string productName = Console.ReadLine();
					int index = allProductNames.IndexOf(productName);
					if (index != -1)
					{
						Console.Write("What is your new quantity? ");
						int productQuantity = int.Parse(Console.ReadLine());
						allProductQuantities[index] = productQuantity;
						Console.WriteLine("Product quantity updated successfully!");
					}
					else
					{
						Console.WriteLine("Product not found.");
					}
				}
				catch (Exception)
				{
					Console.WriteLine("Unable to update product quantity, try again.");
				}
			}
            static void choice3()
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
		}
    }
}
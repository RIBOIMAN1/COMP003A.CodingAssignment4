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
                        Console.WriteLine("Inventory Management System Menu:");
                        Console.WriteLine("1. Add a Product");
                        Console.WriteLine("2. Update Product Quantity");
                        Console.WriteLine("3. View Inventory Summary");
                        Console.WriteLine("4. Exit");
                        Console.Write("Enter you choice: ");
                        inventoryManagement = int.Parse(Console.ReadLine());
                        if (inventoryManagement == 1)
                        {
                            Console.Write("Enter product name: ");
                            productName = Console.ReadLine();
                            Console.Write("Enter product quantity: ");
                            productQuantity = int.Parse(Console.ReadLine());
                            Console.WriteLine("Product added successfully!");
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
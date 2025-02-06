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

            Console.WriteLine("Welcome to the Inventory Management System!");
            Console.Write("Choose data storage type: ");
            items = int.Parse(Console.ReadLine());
            if (items != 2 && items != 1)
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
                Console.WriteLine("Choose data storage type:");
                Console.WriteLine("1. Add a Product");
                Console.WriteLine("2. Update Product Quantity");
                Console.WriteLine("3. View Inventory Summary");
                Console.WriteLine("4. Exit");
                Console.Write("Enter you choice: ");
            }
        }
    }
}
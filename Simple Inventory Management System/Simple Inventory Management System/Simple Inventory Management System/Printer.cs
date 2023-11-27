using System;
namespace Simple_Inventory_Management_System
{
	public static class Printer 
	{
        public static void Menu()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. View Products");
            Console.WriteLine("3. Edit Product");
            Console.WriteLine("4. Delete Product");
            Console.WriteLine("5. Search Product");
            Console.WriteLine("6. Exit");
            Console.WriteLine("------------------");
            Console.Write("Enter choice: ");
        }
        public static void AddName()
        {
            Console.Write("Enter product name: ");
        }
        public static void AddPrice()
        {
            Console.Write("Enter product price: ");
        }
        public static void AddQuantity()
        {
            Console.Write("Enter product quantity: ");
        }
        public static void ViewExist()
        {
            Console.Write("Enter existing product name: ");
        }
        public static void ViewName()
        {
            Console.Write("Enter new name: ");
        }
        public static void ViewPrice()
        {
            Console.Write("Enter new price: ");
        }
        public static void ViewQuantity()
        {
            Console.Write("Enter new quantity: ");
        }
        public static void Delete()
        {
            Console.Write("Enter product name to delete: ");
        }
        public static void Search()
        {
            Console.Write("Enter product name to search: ");
        }
        public static void InvaildInput()
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}


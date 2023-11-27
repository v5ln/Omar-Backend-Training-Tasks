using System;
using Simple_Inventory_Management_System;

class Program
{
    
    static void Main(string[] args)
    {
        var inventory = new Inventory();

        while (true)
        {
            Printer.Menu();
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Printer.AddName();
                    string name = Console.ReadLine();
                    Printer.AddPrice();
                    decimal price = Convert.ToDecimal(Console.ReadLine());
                    Printer.AddQuantity();
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    inventory.AddProduct(name, price, quantity);
                    break;
                case 2:
                    inventory.ViewProducts();
                    break;
                case 3:
                    Printer.ViewExist();
                    string existingName = Console.ReadLine();
                    Printer.ViewName();
                    string newName = Console.ReadLine();
                    Printer.ViewPrice();
                    decimal newPrice = Convert.ToDecimal(Console.ReadLine());
                    Printer.ViewQuantity();
                    int newQuantity = Convert.ToInt32(Console.ReadLine());
                    inventory.EditProduct(existingName, newName, newPrice, newQuantity);
                    break;
                case 4:
                    Printer.Delete();
                    string deleteName = Console.ReadLine();
                    inventory.DeleteProduct(deleteName);
                    break;
                case 5:
                    Printer.Search();
                    string searchName = Console.ReadLine();
                    inventory.SearchProduct(searchName);
                    break;
                case 6:
                    return;
                default:
                    Printer.InvaildInput();
                    break;
            }
        }
    }
}

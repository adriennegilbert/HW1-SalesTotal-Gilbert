using System;

// MIS 3013 Homework 1 - SalesTotal Adrienne Gilbert

/* Create a C# .NET Core console application (after connecting to Github repository) with a project named SalesTotal that contains the following:
1. Prompt the user to enter what type of item they are purchasing
2. Prompt the user to enter how many of <item>
3. Prompt the user for the price of one item
4. Calculate the subtotal, the sales tax and the sales total (subtotal + sales tax) and output all 3 to the user.  Assume that the sales tax for your application is 8.5% (create a constant to store this value and use the constant in your calculations).
5. Push changes to Github. Make sure to check that your files are uploaded properly: https://github.com/ou-mis/homework1-<your Github username here> */

namespace HW1Gilbert
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter what type of item they are purchasing
            Console.WriteLine("What is the product name of the item you are purcasing?");
            string itemProductName = Console.ReadLine();

            // Prompt the user to enter how many of <item>
            Console.WriteLine($"\n\rHow many {itemProductName}'s do you want to buy?");
            double itemQuantity = Convert.ToDouble(Console.ReadLine());
            
            // Prompt the user to enter the price of <item>
            Console.WriteLine($"\n\rWhat is the price for each {itemProductName}?");
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            // Calculate the subtotal, the sales tax and the sales total (subtotal + sales tax) and output all 3 to the user
            double billSubtotal;
            double taxRate = .085;
            double salesTax;
            Console.WriteLine($"\n\r\tYour subtotal for your bill is ${(billSubtotal = itemQuantity * itemPrice):N2}.\n\r\tYour sales tax for your bill is ${(salesTax = (itemQuantity * itemPrice) * taxRate):N2}.\n\r\tYour total for your bill is ${(billSubtotal + salesTax):N2}.\n\n\rPress any key to continue . . .");

            Console.ReadKey();
        }
    }
}

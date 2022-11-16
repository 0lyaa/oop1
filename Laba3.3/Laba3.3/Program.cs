using Laba3._3;
using System;

namespace Laba3
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter article: ");
            string article = Console.ReadLine();

            Console.Write("Enter quantity: ");
            int quantity = Int32.Parse(Console.ReadLine());

            Console.Write("Enter account: ");
            int account = Int32.Parse(Console.ReadLine());

            Console.Write("Enter customer: ");
            string customer = Console.ReadLine();

            Console.Write("Enter provider: ");
            string provider = Console.ReadLine();

            Invoice invoice = new Invoice(article, quantity, account, customer, provider);

            Console.WriteLine("Account without pdv: " + invoice.WithoutPDV() + "$");
            Console.WriteLine("Account with pdv: " + invoice.WithPDV() + "$");
        }
    }
}
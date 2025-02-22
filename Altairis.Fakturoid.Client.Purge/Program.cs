using System;
using System.Linq;

namespace Altairis.Fakturoid.Client.Purge {
    internal class Program {
        private static void Main(string[] args) {
            // Show banner
            Console.WriteLine("Fakturoid API v3 C#/.NET Client Purge Application");
            Console.WriteLine("http://github.com/ridercz/Fakturoid-API");
            Console.WriteLine("Copyright (c) Michal A. Valášek - Altairis, 2013-2025");
            Console.WriteLine();

            // Verify commandline arguments
            if (args.Length != 3) {
                Console.WriteLine("USAGE: fpurge accountname clientid clientsecret");
                return;
            }
            var accountName = args[0];
            var clientId = args[1];
            var clientSecret = args[2];

            // Create context
            var context = new FakturoidContext(accountName, clientId, clientSecret, "Fakturoid API v3 C#/.NET Client Purge Application (fakturoid@rider.cz)");

            // Get account info
            var info = context.GetAccountInfoAsync().Result;
            Console.WriteLine("Company name:     {0}", info.Name);
            Console.WriteLine("Company reg. no.: {0}", info.RegistrationNo);
            Console.WriteLine("Account name:     {0}", info.Subdomain);
            Console.WriteLine();

            // Verify if user really wants to delete all
            var oldBg = Console.BackgroundColor;
            var oldFg = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("  This application will DELETE all subjects and invoices in this account!      ");
            Console.WriteLine("  It comes handy in development, but can be disastrous in production.          ");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.BackgroundColor = oldBg;
            Console.ForegroundColor = oldFg;

            Console.WriteLine();
            Console.WriteLine("Type 'yes' (without quotes) and press ENTER if you want to do that.");
            var r = Console.ReadLine();
            if (!r.Equals("yes")) {
                Console.WriteLine("Cancelled.");
                return;
            }
            Console.WriteLine();

            // Delete all invoices
            Console.Write("Getting list of invoices...");
            var invoices = context.Invoices.SelectAsync().Result;
            Console.WriteLine($"OK, {invoices.Count()} items");

            Console.WriteLine("Deleting invoices:");
            foreach (var invoice in invoices) {
                Console.Write($"  #{invoice.Id}: ({invoice.Number}) {invoice.ClientName}...");
                context.Invoices.DeleteAsync(invoice.Id).Wait();
                Console.WriteLine("OK");
            }

            // Delete all subjects
            Console.Write("Getting list of subjects...");
            var subjects = context.Subjects.SelectAsync().Result;
            Console.WriteLine($"OK, {subjects.Count()} items");

            Console.WriteLine("Deleting subjects:");
            foreach (var subject in subjects) {
                Console.Write($"  #{subject.Id}: {subject.Name}...");
                context.Subjects.DeleteAsync(subject.Id).Wait();
                Console.WriteLine("OK");
            }

            // Okay
            Console.WriteLine("Program execution terminated successfully.");
        }
    }
}

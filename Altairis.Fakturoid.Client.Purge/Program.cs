using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.Fakturoid.Client.Purge {
    class Program {
        static void Main(string[] args) {
            // Show banner
            Console.WriteLine("Fakturoid API C#/.NET Client Purge Application");
            Console.WriteLine("http://github.com/ridercz/Fakturoid-API");
            Console.WriteLine("Copyright (c) Michal A. Valášek - Altairis, 2013");
            Console.WriteLine();

            // Verify commandline arguments 
            if (args.Length != 2) {
                Console.WriteLine("USAGE: fpurge accountname token");
                return;
            }
            var accountName = args[0];
            var accountToken = args[1];

            // Create context
            var context = new FakturoidContext(accountName, accountToken, "Fakturoid API C#/.NET Client Demo Application (fakturoid@rider.cz)");

            // Get account info
            var info = context.GetAccountInfo();
            Console.WriteLine("Company name:     {0}", info.name);
            Console.WriteLine("Company reg. no.: {0}", info.registration_no);
            Console.WriteLine("Account name:     {0}", info.subdomain);
            Console.WriteLine();

            // Verify if user really wants to delete all
            var oldBg = Console.BackgroundColor;
            var oldFg = Console.ForegroundColor;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("  This application will DELETE all contacts and invoices in this account!      ");
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
            var invoices = context.Invoices.Select(InvoiceType.All, InvoiceStatus.All);
            Console.WriteLine("OK");

            Console.WriteLine("Deleting invoices:");
            foreach (var invoice in invoices) {
                try {
                    Console.Write("  #{0}: ({1}) {2}...", invoice.id, invoice.number, invoice.client_name);
                    context.Invoices.Delete(invoice.id);
                    Console.WriteLine("OK");
                }
                catch (FakturoidException fex) {
                    Console.WriteLine("Failed!");
                    Console.WriteLine("    " + fex.Message);
                }
            }

            // Delete all subjects
            Console.Write("Getting list of subjects...");
            var subjects = context.Subjects.Select();
            Console.WriteLine("OK");

            Console.WriteLine("Deleting subjects:");
            foreach (var subject in subjects) {
                try {
                    Console.Write("  #{0}: {1}...", subject.id, subject.name);
                    context.Subjects.Delete(subject.id);
                    Console.WriteLine("OK");
                }
                catch (FakturoidException fex) {
                    Console.WriteLine("Failed!");
                    Console.WriteLine("    " + fex.Message);
                    Console.WriteLine(fex.Message);
                }
            }

            // Okay
            Console.WriteLine("Program execution terminated successfully.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altairis.Fakturoid.Client;

namespace Altairis.Fakturoid.Client.DemoApp {
    class Program {
        private static FakturoidContext context;

        static void Main(string[] args) {
            Console.WriteLine("Fakturoid API C#/.NET Client Demo Application");
            Console.WriteLine("http://github.com/ridercz/Fakturoid-API");
            Console.WriteLine("Copyright (c) Michal A. Valášek - Altairis, 2013");
            Console.WriteLine();

            // Verify commandline arguments 
            if (args.Length != 2) {
                Console.WriteLine("USAGE: fdemo accountname token");
                return;
            }
            var accountName = args[0];
            var accountToken = args[1];

            // Create context
            context = FakturoidContext.Create(accountName, accountToken, "Fakturoid API C#/.NET Client Demo Application (fakturoid@rider.cz)");
            
            // Do some magic
            ShowAccountInfo();

            // Wait for ENTER
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        private static void ShowAccountInfo() {
            Console.Write("Getting account information...");
            var ai = context.Account.Select();
            Console.WriteLine("OK");
            ai.DumpProperties();
            Console.WriteLine();
        }

    }
}

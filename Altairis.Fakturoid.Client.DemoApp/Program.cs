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
            context = new FakturoidContext(accountName, accountToken, "Fakturoid API C#/.NET Client Demo Application (fakturoid@rider.cz)");
            
            // Do some magic
            ShowAccountInfo();
            ShowEvents();
            ShowTodos();
            ShowSubjects();

            // Wait for ENTER
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        private static void ShowSubjects() {
            Console.Write("Creating new subject...");
            var subject = new JsonSubject {
                name = "Altairis, s. r. o.",
                street = "Bořivojova 35",
                city = "Praha",
                zip = "17000",
                country = "CZ",
                registration_no = "27560911",
                vat_no = "CZ27560911",
            };
            var newId = context.Subjects.Create(subject);
            Console.WriteLine("OK, ID={0}", newId);

            Console.Write("Getting information about newly created subject...");
            subject = context.Subjects.Select(newId);
            Console.WriteLine("OK, listing properties:");
            subject.DumpProperties(Console.Out, "\t");

            Console.Write("Updating subject...");
            subject.custom_id = "MY_CUSTOM_ID";
            subject = context.Subjects.Update(subject);
            Console.WriteLine("OK, listing properties:");
            subject.DumpProperties(Console.Out, "\t");

            try {
                Console.Write("Causing intentional error...");
                context.Subjects.Create(subject);
                Console.WriteLine("OK (that's unexpected!)");
            }
            catch (FakturoidException fex) {
                Console.WriteLine("Failed! (that's expected)");
                Console.WriteLine(fex.Message);
                foreach (var item in fex.Errors) {
                    Console.WriteLine("\tProperty '{0}': {1}", item.Key, item.Value);
                }
            }

            Console.Write("Deleting newly created contact...");
            context.Subjects.Delete(newId);
            Console.WriteLine("OK");
                        
            Console.WriteLine();
        }

        private static void ShowTodos() {
            Console.Write("Getting all todos...");
            var items = context.Todos.Select();
            Console.WriteLine("OK");

            foreach (var item in items) {
                Console.WriteLine("{0}: ({1}) {2}", item.created_at, item.name, item.text);
            }
            Console.WriteLine();
        }

        private static void ShowEvents() {
            Console.Write("Getting all events...");
            var items = context.Events.Select();
            Console.WriteLine("OK");

            foreach (var item in items) {
                Console.WriteLine("{0}: ({1}) {2}", item.created_at, item.name, item.text);
            }
            Console.WriteLine();
        }

        private static void ShowAccountInfo() {
            Console.Write("Getting account information...");
            var ai = context.GetAccountInfo();
            Console.WriteLine("OK");

            ai.DumpProperties();
            Console.WriteLine();
        }

    }
}

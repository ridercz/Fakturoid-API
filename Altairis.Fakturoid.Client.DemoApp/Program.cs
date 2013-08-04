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
            //ShowAccountInfo();
            //ShowEvents();
            //ShowTodos();
            //ShowSubjects();
            ShowInvoices();

            // Wait for ENTER
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        private static void ShowInvoices() {
            Console.Write("Creating new subject...");
            var subjectId = context.Subjects.Create(new JsonSubject {
                name = "ACME, s. r. o.",
                street = "Testovací 123",
                city = "Praha",
                zip = "11000",
                country = "CZ",
                registration_no = "12345678",
                vat_no = "CZ12345678",
                email = "acmecorp@mailinator.com"
            });
            Console.WriteLine("OK, ID={0}", subjectId);

            Console.Write("Creating new invoice...");
            var newInvoice = new JsonInvoice {
                subject_id = subjectId,
                client_street = "Jiná ulice 123",
                lines = new List<JsonInvoiceLine>(),
            };
            newInvoice.lines.Add(new JsonInvoiceLine { name = "Položka 1", quantity = 1, unit_name = "ks", unit_price = 100, vat_rate = 21 });
            newInvoice.lines.Add(new JsonInvoiceLine { name = "Položka 2", quantity = 3, unit_name = "hod.", unit_price = 1234, vat_rate = 21 });
            var newInvoiceId = context.Invoices.Create(newInvoice);
            Console.WriteLine("OK, ID={0}", newInvoiceId);

            Console.Write("Reading back invoice information...");
            newInvoice = context.Invoices.SelectSingle(newInvoiceId);
            Console.WriteLine("OK");

            Console.Write("Sending invoice by e-mail...");
            context.Invoices.SendMessage(newInvoiceId, InvoiceMessageType.InvoiceMessage);
            Console.WriteLine("OK");

            Console.Write("Marking invoice as paid...");
            context.Invoices.SetPaymentStatus(newInvoiceId, InvoicePaymentStatus.Paid);
            Console.WriteLine("OK");

            Console.Write("Deleting invoice...");
            context.Invoices.Delete(newInvoiceId);
            Console.WriteLine("OK");

            Console.Write("Deleting subject...");
            context.Subjects.Delete(subjectId);
            Console.WriteLine("OK");
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
            subject = context.Subjects.SelectSingle(newId);
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
            Console.Write("Getting all events in last 24 hour...");
            var items = context.Events.Select(since: DateTime.Now.AddDays(-1));
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

            ai.DumpProperties(Console.Out, "\t");
            Console.WriteLine();
        }

    }
}

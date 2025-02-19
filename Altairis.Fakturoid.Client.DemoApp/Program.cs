using System;
using System.Collections.Generic;
using System.Linq;
using Altairis.Fakturoid.Client.Models;

namespace Altairis.Fakturoid.Client.DemoApp {
    internal class Program {
        private static FakturoidContext context;

        private static void Main(string[] args) {
            Console.WriteLine("Fakturoid API v3 C#/.NET Client Demo Application");
            Console.WriteLine("http://github.com/ridercz/Fakturoid-API");
            Console.WriteLine("Copyright (c) Michal A. Valášek - Altairis, 2013-2025");
            Console.WriteLine();

            // Verify commandline arguments
            if (args.Length != 3) {
                Console.WriteLine("USAGE: fdemo accountname clientid clientsecret");
                return;
            }
            var accountName = args[0];
            var clientId = args[1];
            var clientSecret = args[2];

            // Create context
            context = new FakturoidContext(accountName, clientId, clientSecret);

            // Do some magic
            try {
                ShowAccountInfo();
                ShowSubjects();
                //ShowEvents();
                //ShowTodos();
                //ShowInvoices();
                //SearchSubjects("Company");
            } catch (AggregateException aex) when (aex.InnerExceptions.Count == 1) {
                throw aex.InnerException;
            }

            // Wait for ENTER
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        //private static void ShowInvoices() {
        //    Console.Write("Creating new subject...");
        //    var subjectId = context.Subjects.Create(new JsonSubject {
        //        name = "ACME, s. r. o.",
        //        street = "Testovací 123",
        //        city = "Praha",
        //        zip = "11000",
        //        country = "CZ",
        //        registration_no = "12345678",
        //        vat_no = "CZ12345678",
        //        email = "acmecorp@mailinator.com"
        //    });
        //    Console.WriteLine("OK, ID={0}", subjectId);

        //    Console.Write("Creating new invoice...");
        //    var newInvoice = new JsonInvoice {
        //        subject_id = subjectId,
        //        client_street = "Jiná ulice 123",
        //        lines = new List<JsonInvoiceLine>(),
        //    };
        //    newInvoice.lines.Add(new JsonInvoiceLine { name = "Položka 1", quantity = 1, unit_name = "ks", unit_price = 100, vat_rate = 21 });
        //    newInvoice.lines.Add(new JsonInvoiceLine { name = "Položka 2", quantity = 3, unit_name = "hod.", unit_price = 1234, vat_rate = 21 });
        //    var newInvoiceId = context.Invoices.Create(newInvoice);
        //    Console.WriteLine("OK, ID={0}", newInvoiceId);

        //    Console.Write("Reading back invoice information...");
        //    newInvoice = context.Invoices.SelectSingle(newInvoiceId);
        //    Console.WriteLine("OK");

        //    Console.Write("Sending invoice by e-mail...");
        //    context.Invoices.SendMessage(newInvoiceId, InvoiceMessageType.InvoiceMessage);
        //    Console.WriteLine("OK");

        //    Console.Write("Marking invoice as paid...");
        //    context.Invoices.SetPaymentStatus(newInvoiceId, InvoicePaymentStatus.Paid);
        //    Console.WriteLine("OK");

        //    Console.Write("Deleting invoice...");
        //    context.Invoices.Delete(newInvoiceId);
        //    Console.WriteLine("OK");

        //    Console.Write("Deleting subject...");
        //    context.Subjects.Delete(subjectId);
        //    Console.WriteLine("OK");
        //}

        private static void ShowSubjects() {
            Console.Write("Creating new subject...");
            var subject = new FakturoidSubject {
                Name = "Altairis, s. r. o.",
                Street = "Bořivojova 35",
                City = "Praha 3",
                Zip = "1300",
                Country = "CZ",
                RegistrationNo = "27560911",
                VatNo = "CZ27560911",
            };
            var newId = context.Subjects.CreateAsync(subject).Result;
            Console.WriteLine("OK, ID={0}", newId);

            Console.Write("Getting information about newly created subject...");
            subject = context.Subjects.SelectSingleAsync(newId).Result;
            Console.WriteLine("OK, listing properties:");
            subject.DumpProperties(Console.Out, "\t");

            Console.Write("Updating subject...");
            subject.CustomId = "MY_CUSTOM_ID";
            subject = context.Subjects.UpdateAsync(subject).Result;
            Console.WriteLine("OK, listing properties:");
            subject.DumpProperties(Console.Out, "\t");

            try {
                Console.Write("Causing intentional error...");
                context.Subjects.CreateAsync(subject).Wait();
                Console.WriteLine("OK (that's unexpected!)");
            } catch (AggregateException ex) {
                var fex = ex.InnerException as FakturoidException;
                if (fex != null) {
                    Console.WriteLine("Failed! (that's expected)");
                    Console.WriteLine(fex.Message);
                    foreach (var item in fex.Errors) {
                        Console.WriteLine("\tProperty '{0}': {1}", item.Key, item.Value);
                    }
                } else {
                    throw;
                }
            }

            Console.Write("Deleting newly created subject...");
            context.Subjects.DeleteAsync(newId).Wait();
            Console.WriteLine("OK");

            Console.WriteLine();
        }

        //private static void SearchSubjects(string searchTerm) {
        //    Console.Write($"Searching Subjects. Term: {searchTerm}...");
        //    var subjects = context.Subjects.Search(searchTerm);
        //    Console.WriteLine("OK");
        //    foreach (var subject in subjects) {
        //        Console.WriteLine("Name: {0}, RegNo: {1}", subject.name, subject.registration_no);
        //    }
        //    Console.WriteLine();
        //}

        //private static void ShowTodos() {
        //    Console.Write("Getting all todos...");
        //    var items = context.Todos.Select();
        //    Console.WriteLine("OK");

        //    foreach (var item in items) {
        //        Console.WriteLine("{0}: ({1}) {2}", item.created_at, item.name, item.text);
        //    }
        //    Console.WriteLine();
        //}

        //private static void ShowEvents() {
        //    Console.Write("Getting all events in last 24 hour...");
        //    var items = context.Events.Select(since: DateTime.Now.AddDays(-1));
        //    Console.WriteLine("OK");

        //    foreach (var item in items) {
        //        Console.WriteLine("{0}: ({1}) {2}", item.created_at, item.name, item.text);
        //    }
        //    Console.WriteLine();
        //}

        private static void ShowAccountInfo() {
            Console.Write("Getting account information...");
            var ai = context.GetAccountInfoAsync().Result;
            Console.WriteLine("OK");
            ai.DumpProperties(Console.Out, "\t");

            Console.Write("Getting bank accounts...");
            var ba = context.BankAccounts.SelectAsync().Result.ToArray();
            Console.WriteLine("OK, {0} found", ba.Length);
            for (var i = 0; i < ba.Length; i++) {
                Console.WriteLine("Item #{0}:", i);
                ba[i].DumpProperties(Console.Out, "\t");
            }

            Console.Write("Getting number formats...");
            var nf = context.NumberFormats.SelectAsync().Result.ToArray();
            Console.WriteLine("OK, {0} found", nf.Length);
            for (var i = 0; i < nf.Length; i++) {
                Console.WriteLine("Item #{0}:", i);
                nf[i].DumpProperties(Console.Out, "\t");
            }

            Console.WriteLine();
        }

    }
}

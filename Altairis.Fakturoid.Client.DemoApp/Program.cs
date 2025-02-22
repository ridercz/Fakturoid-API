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
                SearchSubjects("Company");
                ShowTodos();
                ShowEvents();
                ShowInvoices();
            } catch (AggregateException aex) when (aex.InnerExceptions.Count == 1) {
                throw aex.InnerException;
            }

            // Wait for ENTER
            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        private static void ShowInvoices() {
            Console.Write("Creating new subject...");
            var subject = new FakturoidSubject {
                Name = "ACME, s. r. o.",
                Street = "Testovací 123",
                City = "Praha",
                Zip = "11000",
                Country = "CZ",
                RegistrationNo = "12345678",
                VatNo = "CZ12345678",
                Email = "acmecorp@mailinator.com"
            };
            var subjectId = context.Subjects.CreateAsync(subject).Result;
            Console.WriteLine($"OK, ID={subjectId}");

            Console.Write("Creating new invoice...");
            var newInvoice = new FakturoidInvoice {
                SubjectId = subjectId, 
                ClientStreet = "Jiná ulice 123",
                Lines = new List<FakturoidLine>(),
            };
            newInvoice.Lines.Add(new FakturoidLine { Name = "Položka 1", Quantity = 1, UnitName = "ks", UnitPrice = 100, VatRate = 21 });
            newInvoice.Lines.Add(new FakturoidLine { Name = "Položka 2", Quantity = 3, UnitName = "hod.", UnitPrice = 1234, VatRate = 21 });
            var newInvoiceId = context.Invoices.CreateAsync(newInvoice).Result;
            Console.WriteLine($"OK, ID={newInvoiceId}");

            Console.Write("Reading back invoice information...");
            newInvoice = context.Invoices.SelectSingleAsync(newInvoiceId).Result;
            Console.WriteLine("OK");

            Console.Write("Deleting invoice...");
            context.Invoices.DeleteAsync(newInvoiceId).Wait();
            Console.WriteLine("OK");

            Console.Write("Deleting subject...");
            context.Subjects.DeleteAsync(subjectId).Wait();
            Console.WriteLine("OK");
        }

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
            var rng = new Random();
            subject.CustomId = rng.Next(rng.Next()).ToString();
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
                        Console.WriteLine($"\tProperty '{item.Key}': {item.Value}");
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

        private static void SearchSubjects(string searchTerm) {
            Console.Write($"Searching Subjects. Term: {searchTerm}...");
            var subjects = context.Subjects.SearchAsync(searchTerm).Result;
            Console.WriteLine("OK");
            foreach (var subject in subjects) {
                Console.WriteLine($"Name: {subject.Name}, RegNo: {subject.RegistrationNo}");
            }
            Console.WriteLine();
        }

        private static void ShowTodos() {
            Console.Write("Getting all todos...");
            var items = context.Todos.SelectAsync().Result;
            Console.WriteLine("OK");

            foreach (var item in items) {
                Console.WriteLine($"{item.CreatedAt}: ({item.Name}) {item.Text} {(item.CompletedAt.HasValue ? "(completed)" : "(not completed)")}");
            }
            Console.WriteLine();
        }

        private static void ShowEvents() {
            Console.Write("Getting all events in last 24 hours...");
            var items = context.Events.SelectAsync(DateTime.Now.AddDays(-1)).Result;
            Console.WriteLine("OK");

            foreach (var item in items) {
                Console.WriteLine($"{item.CreatedAt}: ({item.Name}) {item.Text}");
            }
            Console.WriteLine();
        }

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

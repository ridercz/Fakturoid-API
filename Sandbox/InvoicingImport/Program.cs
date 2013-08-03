using Altairis.Fakturoid.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoicingImport.Data;

namespace InvoicingImport {
    class Program {
        private static FakturoidContext context;
        private static Dictionary<int, int> subjectIdMap;

        static void Main(string[] args) {
            // Verify commandline arguments 
            if (args.Length != 2) {
                Console.WriteLine("USAGE: InvoicingImport accountname token");
                return;
            }
            var accountName = args[0];
            var accountToken = args[1];

            // Create API context
            context = new FakturoidContext(accountName, accountToken);

            // Process all operations
            PurgeAll();
            ImportContacts();
        }

        private static void ImportContacts() {
            Console.WriteLine("Importing contacts:");
            subjectIdMap = new Dictionary<int, int>();
            using (var dc = new InvoicingEntities()) {
                foreach (var c in dc.Contacts) {
                    try {
                        Console.Write("  #{0}: {1}...", c.ContactId, c.CompanyName);
                        var newSubject = new JsonSubject {
                            bank_account = c.BankAccountNumber,
                            city = c.DefaultBillAddress.City,
                            country = c.DefaultBillAddress.Country,
                            custom_id = c.ContactId.ToString(),
                            email = c.ContactEmail,
                            full_name = c.ContactName,
                            name = c.CompanyName,
                            phone = c.ContactMobile,
                            registration_no = c.ICO,
                            street = c.DefaultBillAddress.Street,
                            vat_no = c.DIC,
                            zip = c.DefaultBillAddress.ZIP
                        };
                        var newId = context.Subjects.Create(newSubject);
                        Console.WriteLine("OK, ID={0}", newId);
                        subjectIdMap.Add(c.ContactId, newId);
                    }
                    catch (FakturoidException) {
                        Console.WriteLine("Failed!");
                    }
                }
            }

            
        }
        
        private static void PurgeAll() {
            // Delete all subjects
            Console.Write("Listing all subjects...");
            var subjects = context.Subjects.Select();
            Console.WriteLine("OK");

            Console.WriteLine("Deleting subjects:");
            foreach (var subject in subjects) {
                Console.Write("  #{0}: {1}...", subject.id, subject.name);
                try {
                    context.Subjects.Delete(subject.id);
                    Console.WriteLine("OK");
                }
                catch (FakturoidException fex) {
                    Console.WriteLine(fex.Message);
                }
            }
        }
    }
}

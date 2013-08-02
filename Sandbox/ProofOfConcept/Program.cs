using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ProofOfConcept {
    class Program {
        private const string API_USER_AGENT = "Altairis Fakturoid API client (fakturoid@rider.cz)";
        private const string API_BASE_URL_FORMAT = "https://{0}.fakturoid.cz/api/v1/";

        static void Main(string[] args) {

            // Read commandline arguments
            if (args.Length != 2) {
                Console.WriteLine("USAGE: fpoc accountname token" );
                return;
            }
            var accountName = args[0];
            var token = args[1];
            
            // Get value of authentication header
            var authHeader = Convert.ToBase64String(Encoding.UTF8.GetBytes("X:" + token));

            // Setup HTTP client
            var client = new HttpClient();
            client.BaseAddress = new Uri(string.Format(API_BASE_URL_FORMAT, accountName));
            client.DefaultRequestHeaders.Add("User-Agent", API_USER_AGENT);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeader);

            // Create new contact
            Console.WriteLine("Creating subjects...");
            Console.WriteLine(CreateSubject(client, new JsonSubject {
                name = "Altairis, s. r. o.",
                street = "Bořivojova 35",
                city = "Praha",
                zip = "17000",
                country = "CZ",
                registration_no = "27560911",
                vat_no = "CZ27560911",
                web = "http://www.altairis.cz/",
            }));
            Console.WriteLine(CreateSubject(client, new JsonSubject {
                name = "Test, s. r. o.",
                street = "Bořivojova 35",
                city = "Praha",
                zip = "17000",
                country = "CZ",
                registration_no = "27560912",
                vat_no = "CZ27560912",
                web = "http://www.altairis.cz/",
            }));

            // List existing contacts
            Console.WriteLine("Listing subjects:");
            var subjects = ListSubjects(client);
            foreach (var subject in subjects) {
                Console.WriteLine(string.Join("\t", subject.id, subject.registration_no, subject.name));
            }

            // Delete all existing contacts
            foreach (var subject in subjects) {
                Console.Write("Deleting subject {0} (#{1})...", subject.name, subject.id);
                try {
                    DeleteSubject(client, subject.id);
                    Console.WriteLine("OK");
                }
                catch (Exception ex) {
                    Console.WriteLine("Failed!");
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("Press ENTER to continue...");
            Console.ReadLine();
        }

        private static IEnumerable<JsonSubject> ListSubjects(HttpClient client) {
            var r = client.GetAsync("subjects.json").Result;
            r.EnsureSuccessStatusCode();
            return r.Content.ReadAsAsync<IEnumerable<JsonSubject>>().Result;
        }

        private static Uri CreateSubject(HttpClient client, JsonSubject subject) {
            var r = client.PostAsJsonAsync<JsonSubject>("subjects.json", subject).Result;
            r.EnsureSuccessStatusCode();
            return r.Headers.Location;
        }

        private static void DeleteSubject(HttpClient client, int id) {
            var r = client.DeleteAsync("subjects/" + id).Result;
            r.EnsureSuccessStatusCode();
        }
    }
}

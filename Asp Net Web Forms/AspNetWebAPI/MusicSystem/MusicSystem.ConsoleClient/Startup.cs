namespace MusicSystem.ConsoleClient
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading;

    using Data;
    using Data.Contracts;
    using Newtonsoft.Json.Linq;

    public class Startup
    {
        private const string ConnectionPath = "http://localhost:51634/";
        private const string RequestPath = "api/Countries/";

        private static readonly IMusicSystemData Data = new MusicSystemData();

        public static void Main()
        {
            Console.WriteLine("This may take a moment...");
            Thread.Sleep(3000);

            var connection = new Uri(ConnectionPath);

            Console.WriteLine("Creating new country...");
            PostJsonCountry(connection);           
            GetXmlCountries(connection);
            Console.Write("Country created! Press any key to continue...");

            Console.ReadLine();

            Console.WriteLine("Updating country...");
            PutCountry(connection, 1);
            GetXmlCountries(connection);
            Console.Write("Country updated! Press any key to continue...");

            Console.ReadLine();

            Console.WriteLine("Deleting country...");
            DeleteJsonCountry(connection, 1);
            GetXmlCountries(connection);
            Console.Write("Country deleted! Press any key to continue...");

            Console.ReadLine();
        }

        private static async void GetXmlCountries(Uri connection)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/xml"));

                var response = await httpClient.GetAsync(RequestPath);
                Console.WriteLine(Environment.NewLine + "Countries: " + await response.Content.ReadAsStringAsync());
            }
        }

        private static async void PostJsonCountry(Uri connection)
        {
            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;

                var country = JObject.Parse(@"{""Name"": ""China""}");

                var response = await httpClient.PostAsync(
                    RequestPath,
                    new StringContent(
                        country.ToString(),
                        Encoding.UTF8,
                        "application/json"));

                Console.WriteLine(Environment.NewLine + await response.Content.ReadAsStringAsync());
            }
        }

        private static async void PutCountry(Uri connection, int id)
        {
            if (Data.Countries.GetById(id) == null)
            {
                Console.WriteLine("Country not found.");
                return;
            }

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;

                var country = JObject.Parse(@"{""Name"": ""Portugal""}");

                var response = await httpClient.PutAsync(
                    RequestPath + id,
                    new StringContent(
                        country.ToString(),
                        Encoding.UTF8,
                        "application/json"));

                Console.WriteLine(Environment.NewLine + "Updated country: " + await response.Content.ReadAsStringAsync());
            }
        }

        private static async void DeleteJsonCountry(Uri connection, int id)
        {
            if (Data.Countries.GetById(id) == null)
            {
                Console.WriteLine("Country not found.");
                return;
            }

            using (var httpClient = new HttpClient())
            {
                httpClient.BaseAddress = connection;

                var response = await httpClient.DeleteAsync(RequestPath + id);

                Console.WriteLine(Environment.NewLine + "Country deleted: " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}

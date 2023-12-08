using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;



namespace InsuranceOrg.Tests;

public class Clientusage
{
    public async Task Use()
    {
        // URL of the Web API
        string apiUrl = "https://api.example.com/data";

        // Call the method to get data from the Web API
        MyModel result = await GetDataFromApi<MyModel>(apiUrl);

        // Use the result as needed
        if (result != null)
        {
            Console.WriteLine($"Id: {result.Id}, Name: {result.Name}");
        }

        else
        {
            Console.WriteLine("Failed to fetch data from the API.");
        }
    }
    
    public async Task<T> GetDataFromApi<T>(string apiUrl)
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                // Make the HTTP request to the API
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Check if the request was successful (status code 200)
                if (response.IsSuccessStatusCode)
                {
                    // Read the content as a string
                    string jsonContent = await response.Content.ReadAsStringAsync();

                    // Deserialize the JSON string to the specified C# model
                    T result = JsonConvert.DeserializeObject<T>(jsonContent);

                    return result;
                }
                else
                {
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                    return default; // or throw an exception based on your requirements
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                return default;
            }
        }
    }
}


public class MyModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    // Add other properties as needed
}
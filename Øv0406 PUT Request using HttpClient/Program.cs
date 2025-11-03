using System.Text;

HttpClient client = new HttpClient();

string jsonData = "{\"id\": 1, \"title\": \"updated title\", \"body\": \"updated body\", \"userId\": 1}";

StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

HttpResponseMessage response = await client.PutAsync(
    "https://jsonplaceholder.typicode.com/posts/1", content);
string responseBody = await response.Content.ReadAsStringAsync();

Console.WriteLine($"Status Code: {(int) response.StatusCode}, {response.StatusCode}");
Console.WriteLine($"Response Body: {responseBody}");

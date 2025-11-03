using System.Text;

HttpClient client = new HttpClient();

string jsonData = "{\"title\": \"foo\", \"body\": \"bar\", \"userId\": 1}";

StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

HttpResponseMessage response = await client.PostAsync("https://jsonplaceholder.typicode.com/posts", content);
string responseBody = await response.Content.ReadAsStringAsync();

Console.WriteLine($"Status Code: {(int) response.StatusCode}, {response.StatusCode}");
Console.WriteLine($"Response Body: {responseBody}");

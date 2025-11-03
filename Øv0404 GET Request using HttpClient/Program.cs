// HttpClient is intended to be instantiated once per application, rather than per-use.
HttpClient client = new HttpClient();

HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts");
string responseBody = await response.Content.ReadAsStringAsync();


Console.WriteLine($"Status Code: {(int) response.StatusCode}, {response.StatusCode}");
Console.WriteLine($"Response Body: {responseBody}");
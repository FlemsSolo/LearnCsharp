using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configure Kestrel to listen on http://localhost:80
builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(88); // binds to 127.0.0.1:80
});

var app = builder.Build();

// In-memory list of posts
var posts = new List<Post>
{
    new Post { Id = 1, UserId = 1, Title = "Post 1", Body = "Body of Post 1" },
    new Post { Id = 2, UserId = 1, Title = "Post 2", Body = "Body of Post 2" }
};

// GET endpoint to retrieve all posts
app.MapGet("/posts", () => posts);

// GET endpoint to retrieve a specific post by ID
app.MapGet("/posts/{id:int}", (int id) =>
{
    var post = posts.FirstOrDefault(p => p.Id == id);
    return post is not null ? Results.Ok(post) : Results.NotFound("Post not found");
});

app.Run();

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
}
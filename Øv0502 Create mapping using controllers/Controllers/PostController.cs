using Microsoft.AspNetCore.Mvc;
//using ControllerBasedWebAPI;

namespace Øv0502_Create_mapping_using_controllers.Controllers;

[ApiController]
[Route("[controller]")]
public class PostController : ControllerBase
{
    // In-memory list of posts (for simplicity)
    private static List<Post> posts = new List<Post>
    {
        new Post { Id = 1, UserId = 1, Title = "Post 1", Body = "Body of Post 1" },
        new Post { Id = 2, UserId = 1, Title = "Post 2", Body = "Body of Post 2" }
    };

    // Test GET endpoint : http://localhost:88
    [HttpGet("/")]
    public IActionResult GetWelcomeMessage()
    {
        return Ok("Hello, I am a Controller-based API!");
    }

    // GET endpoint to retrieve all posts : http://localhost:88/post
    [HttpGet]
    public ActionResult<IEnumerable<Post>> GetAllPosts()
    {
        return Ok(posts);
    }

    // GET endpoint to retrieve a specific post by ID: http://localhost:88/post/1
    [HttpGet("{id:int}")] 
    public IActionResult GetPostById(int id)
    {
        var post = posts.FirstOrDefault(p => p.Id == id);
        return post is not null ? Ok(post) : NotFound("Post not found");
    }

    // POST endpoint to add a new post
    // POST + BODY {"userId":1,"title":"Post 3","body":"Body of Post 3"} 
    // ID can be missing or present. Always overridden with Max(id) see code
    [HttpPost]
    public IActionResult CreatePost(Post newPost)
    {
        newPost.Id = posts.Max(p => p.Id) + 1; // Assign a new ID
        posts.Add(newPost);
        return CreatedAtAction(nameof(GetPostById), new { id = newPost.Id }, newPost);
    }

    // PUT endpoint to update an existing post
    // PUT http://localhost:88/post/4 + BODY {"userId":1,"title":"Post 3","body":"Body of Post 3"} 
    // ID can be missing or present in the BODY.code Always overridden by HttpPut parameter
    [HttpPut("{id:int}")]
    public IActionResult UpdatePost(int id, Post updatedPost)
    {
        var postIndex = posts.FindIndex(p => p.Id == id);
        if (postIndex == -1)
        {
            return NotFound("Post not found");
        }

        updatedPost.Id = id; // Ensure the ID remains unchanged
        posts[postIndex] = updatedPost;
        return Ok(posts[postIndex]);
    }

    // DELETE endpoint to delete a post by ID
    // DELETE + http://localhost:88/post/4 
    [HttpDelete("{id:int}")]
    public IActionResult DeletePost(int id)
    {
        var post = posts.FirstOrDefault(p => p.Id == id);
        if (post is null)
        {
            return NotFound("Post not found");
        }

        posts.Remove(post);
        return NoContent();
    }
}
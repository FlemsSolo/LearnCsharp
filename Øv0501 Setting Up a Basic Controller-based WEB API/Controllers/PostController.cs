using Microsoft.AspNetCore.Mvc;

namespace Øv0501_Setting_Up_a_Basic_Controller_based_WEB_API.Controllers;

[ApiController]
[Route("/")]
public class PostController:ControllerBase
{
    // Test GET endpoint
    [HttpGet("/")]
    public IActionResult GetWelcomeMessage()
    {
        return Ok("Hello, Controller-based API 42 !");
    }
}
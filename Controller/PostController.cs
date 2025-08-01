using System.Runtime.CompilerServices;
using Fofoquinha_API.UseCases.CreatePost;
using Microsoft.AspNetCore.Mvc;
namespace Fofoquinha_API.Endpoints;

[ApiController]
[Route("Profile")]
public class PostController
{
    [HttpPost]
    public async Task<IActionResult> Publish([FromBody] CreatePostPayload post)
    {
        
    }
}
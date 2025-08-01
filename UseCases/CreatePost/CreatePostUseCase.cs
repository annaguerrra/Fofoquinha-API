using Fofoquinha_API.UseCases.CreatePost;
using FofoquinhaAPI.Models;
using Microsoft.VisualBasic;

namespace Fofoquinha_API.UseCases.CreateProfile;

public class CreatePostUseCase(FofoquinhaAPIDbContext context)
{
    public async Task<Result<CreatePostResponse>> Do(CreatePostPayload payload)
    {
        return Result<CreatePostResponse>.Ok(null);
    }    
}
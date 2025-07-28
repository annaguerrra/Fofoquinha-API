using System.ComponentModel.DataAnnotations;
using FofoquinhaAPI.Models;

namespace Fofoquinha_API.UseCases.CreatePost;

public record CreatePostPayload
{
    [Required]
    [MinLength(2)]
    [MaxLength(150)]
    public string Content { get; init; }

    [Required]
    public Profile Author{ get; init; }
}
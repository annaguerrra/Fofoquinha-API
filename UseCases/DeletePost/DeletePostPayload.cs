using System.ComponentModel.DataAnnotations;
using FofoquinhaAPI.Models;

namespace Fofoquinha_API.UseCases.DeletePost;

public record DeletePostPayload
{

    [Required]
    public Guid PostID { get; init; }

    [Required]
    public Guid ProfileID{ get; init; }
}
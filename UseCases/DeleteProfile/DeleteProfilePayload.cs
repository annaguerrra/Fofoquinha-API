using System.ComponentModel.DataAnnotations;

namespace Fofoquinha_API.UseCases.DeleteProfile;

public record DeleteProfilePayload
{
    [Required]
    public Guid Profile { get; init; }

    [Required]
    public string Password{ get; init; }
}
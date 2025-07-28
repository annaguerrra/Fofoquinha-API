using System.ComponentModel.DataAnnotations;
using Fofoquinha_API.Validations;
using FofoquinhaAPI.Models;

namespace Fofoquinha_API.UseCases.CreateProfile;

public record CreateProfilePayload
{
    [Required]
    [MinLength(2)]
    [MaxLength(15)]
    public string Username { get; init; }

    [Required]
    [MinLength(8)]
    [MaxLength(30)]
    [NeedNumber]
    public string Password { get; init; }
}

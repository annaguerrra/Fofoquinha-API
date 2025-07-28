namespace FofoquinhaAPI.Models;

public class Profile
{
    public Guid ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Bio { get; set; }
    
    public ICollection<Post> Post { get; set; } = [];
}
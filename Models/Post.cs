using System.Runtime;
using Microsoft.Identity.Client;

namespace FofoquinhaAPI.Models;

public class Post
{
    public Guid id { get; set; }
    public Guid ProfileID { get; set; }
    public string Content { get; set; }
    public DateTime CreateadAt { get; set; }

    public Profile Author { get; set; }
}
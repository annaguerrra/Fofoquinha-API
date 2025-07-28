using Microsoft.EntityFrameworkCore;

namespace FofoquinhaAPI.Models;

public class FofoquinhaAPIDbContext(DbContextOptions opt) : DbContext(opt)
{
    public DbSet<Profile> Profiles => Set<Profile>();
    public DbSet<Post> Posts => Set<Post>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Profile>();

        model.Entity<Post>()
            .HasOne(a => a.Author)
            .WithMany(p => p.Post)
            .HasForeignKey(k => k.ProfileID);
    }

}
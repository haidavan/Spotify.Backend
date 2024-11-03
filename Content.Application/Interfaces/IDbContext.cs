using Content.Domain;
using Microsoft.EntityFrameworkCore;
namespace Content.Application.Interfaces;

public interface IDbContext
{
    DbSet<Album> Albums { get; set; }
    DbSet<Genre> Genres { get; set; }
    DbSet<Group> Groups { get; set; }
    DbSet<Song> Songs { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

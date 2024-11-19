using Content.Domain;

namespace Content.Application.Genres.Queries.GetGenreDetails;

public class GenreVM
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required List<Group> Groups { get; set; }
    public required List<Album> Albums { get; set; }
}

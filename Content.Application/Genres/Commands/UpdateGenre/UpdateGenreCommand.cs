using Content.Domain;
using MediatR;

namespace Content.Application.Genres.Commands.UpdateGenre;

public class UpdateGenreCommand:IRequest
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required List<Group> Groups { get; set; }
    public required List<Album> Albums { get; set; }
}


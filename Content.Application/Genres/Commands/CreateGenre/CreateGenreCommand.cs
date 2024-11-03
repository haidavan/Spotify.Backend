using Content.Domain;
using MediatR;

namespace Content.Application.Genres.Commands.CreateGenre;

public class CreateGenreCommand:IRequest<int>
{
    public required string Title { get; set; }
    public required List<Group> Groups { get; set; }
    public required List<Album> Albums { get; set; }
}


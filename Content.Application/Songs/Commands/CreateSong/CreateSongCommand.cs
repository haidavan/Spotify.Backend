using Content.Domain;
using MediatR;

namespace Content.Application.Songs.Commands.CreateSong;

public class CreateSongCommand:IRequest<int>
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required List<Album> Albums { get; set; }
}

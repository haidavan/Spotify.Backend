using Content.Domain;
using MediatR;

namespace Content.Application.Albums.Commands.CreateAlbum;

public class CreateAlbumCommand : IRequest<int>
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateOnly ReleaseDate { get; set; }
    public required List<Song> Songs { get; set; }
    public required List<Genre> Genres { get; set; }
}

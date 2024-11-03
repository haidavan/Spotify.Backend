using MediatR;
using Content.Domain;
using Content.Application.Interfaces;

namespace Content.Application.Albums.Commands.CreateAlbum;

public class CreateAlbumCommandHandler(IDbContext DbContext) : IRequestHandler<CreateAlbumCommand, int>
{
    public async Task<int> Handle(CreateAlbumCommand request, CancellationToken cancellationToken)
    {
        var album = new Album
        {
            Title = request.Title,
            Description = request.Description,
            ReleaseDate = request.ReleaseDate,
            Songs = request.Songs,
            Genres = request.Genres,
        };

        await DbContext.Albums.AddAsync(album, cancellationToken);
        await DbContext.SaveChangesAsync(cancellationToken);

        return album.Id;
    }
}
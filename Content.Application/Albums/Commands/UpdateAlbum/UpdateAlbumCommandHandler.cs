using Content.Application.Exceptions;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Content.Application.Albums.Commands.UpdateAlbum;

public class UpdateAlbumCommandHandler(IDbContext DbContext): IRequestHandler<UpdateAlbumCommand>
{
    public async Task Handle(UpdateAlbumCommand request,CancellationToken cancellationToken)
    {
        var entity = await DbContext.Albums
           .FirstOrDefaultAsync(album => album.Id == request.Id, cancellationToken) ??
           throw new NotFoundException(nameof(Album), request.Id);

        entity.Title = request.Title;
        entity.Description = request.Description;

        await DbContext.SaveChangesAsync(cancellationToken);
    }
}

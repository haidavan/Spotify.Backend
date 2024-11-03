using MediatR;
using Microsoft.EntityFrameworkCore;
using Content.Application.Exceptions;
using Content.Application.Interfaces;
using Content.Domain;

namespace Content.Application.Albums.Commands.DeleteAlbum;

public class DeleteAlbumCommandHandler(IDbContext DbContext) : IRequestHandler<DeleteAlbumCommand>
{
    public async Task Handle(DeleteAlbumCommand request, CancellationToken cancellationToken)
    {
        var Albums = await DbContext.Albums.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (Albums is null)
        {
            throw new NotFoundException(nameof(Album), request.Id);
        }

        DbContext.Albums.Remove(Albums);
        await DbContext.SaveChangesAsync(cancellationToken);
    }
}
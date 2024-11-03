using Content.Application.Exceptions;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Content.Application.Genres.Commands.UpdateGenre;

public class UpdateGenreCommandHandler(IDbContext DbContext):IRequestHandler<UpdateGenreCommand>
{
    public async Task Handle(UpdateGenreCommand request,CancellationToken cancellationToken)
    {
        var entity = await DbContext.Genres
           .FirstOrDefaultAsync(album => album.Id == request.Id, cancellationToken) ??
           throw new NotFoundException(nameof(Genre), request.Id);
        entity.Title = request.Title;
        entity.Albums= request.Albums;
        entity.Groups = request.Groups;
        await DbContext.SaveChangesAsync(cancellationToken);
    }
}

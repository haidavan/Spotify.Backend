using MediatR;
using Microsoft.EntityFrameworkCore;
using Content.Application.Exceptions;
using Content.Application.Interfaces;
using Content.Domain;

namespace Content.Application.Genres.Commands.DeleteGenre;

public class DeleteGenreCommandHandler(IDbContext DbContext):IRequestHandler<DeleteGenreCommand>
{
    public async Task Handle(DeleteGenreCommand request,CancellationToken cancellationToken)
    {
        var genre= await DbContext.Genres.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (genre is null)
            throw new NotFoundException(nameof(Genre),request.Id);
        DbContext.Genres.Remove(genre);
        await DbContext.SaveChangesAsync(cancellationToken);
    }
}

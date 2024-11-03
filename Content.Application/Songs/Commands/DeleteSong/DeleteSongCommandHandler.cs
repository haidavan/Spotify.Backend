using Content.Application.Exceptions;
using Content.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Content.Domain;

namespace Content.Application.Songs.Commands.DeleteSong;

public class DeleteSongCommandHandler(IDbContext dbContext):IRequestHandler<DeleteSongCommand>
{
    public async Task Handle(DeleteSongCommand request,CancellationToken cancellationToken)
    {
        var song = await dbContext.Songs.FirstOrDefaultAsync(x => x.Id == request.Id);
        if (song == null)
            throw new NotFoundException(nameof(Song), request.Id);
        dbContext.Songs.Remove(song);
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}

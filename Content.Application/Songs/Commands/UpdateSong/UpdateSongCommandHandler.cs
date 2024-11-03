using Content.Application.Exceptions;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Content.Application.Songs.Commands.UpdateSong;

public class UpdateSongCommandHandler(IDbContext dbContext):IRequestHandler<UpdateSongCommand>
{
    public async Task Handle(UpdateSongCommand request,CancellationToken cancellationToken)
    {
        var entity= await dbContext.Songs.FirstOrDefaultAsync(x => x.Id==request.Id)??
            throw new NotFoundException(nameof(Song),request.Id);
        entity.Albums=request.Albums;
        entity.Title=request.Title;
        entity.Description=request.Description;
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}

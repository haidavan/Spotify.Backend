using Content.Application.Interfaces;
using Content.Domain;
using MediatR;

namespace Content.Application.Songs.Commands.CreateSong;

public class CreateSongCommandHandler(IDbContext dbContext):IRequestHandler<CreateSongCommand,int>
{
    public async Task<int> Handle(CreateSongCommand request,CancellationToken cancellationToken)
    {
        var song = new Song()
        {
            Albums = request.Albums,
            Description = request.Description,
            Title = request.Title,
        };
        await dbContext.Songs.AddAsync(song);
        await dbContext.SaveChangesAsync(cancellationToken);
        return song.Id;
    }
}

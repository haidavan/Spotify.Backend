using MediatR;
using Content.Domain;
using Content.Application.Interfaces;

namespace Content.Application.Genres.Commands.CreateGenre;

public class CreateGenreCommandHandler(IDbContext DbContext):IRequestHandler<CreateGenreCommand,int>
{
    public async Task<int> Handle(CreateGenreCommand request,CancellationToken cancellationToken)
    {
        var genre = new Genre
        {
            Title = request.Title,
            Albums = request.Albums,
            Groups = request.Groups,
        };
        await DbContext.Genres.AddAsync(genre,cancellationToken);
        await DbContext.SaveChangesAsync(cancellationToken);
        return genre.Id;
    }
}

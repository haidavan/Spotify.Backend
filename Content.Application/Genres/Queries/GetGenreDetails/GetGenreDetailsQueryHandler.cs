
using AutoMapper;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;

namespace Content.Application.Genres.Queries.GetGenreDetails;

public class GetGenreDetailsQueryHandler(IDbContext dbContext,IMapper mapper):IRequestHandler<GetGenreDetailsQuery,GenreVM>
{
    public async Task<GenreVM> Handle(GetGenreDetailsQuery request,CancellationToken cancellationToken)
    {
        Genre? genre = null;
        foreach(var item in dbContext.Genres)
        {
            if(item.Id== request.Id)
            {
                genre = item;
                break;
            }
        }
        return mapper.Map<GenreVM>(genre);
    }
}

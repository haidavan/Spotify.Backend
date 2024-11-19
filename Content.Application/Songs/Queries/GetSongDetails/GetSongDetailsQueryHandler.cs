using AutoMapper;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;

namespace Content.Application.Songs.Queries.GetSongDetails;

public class GetSongDetailsQueryHandler(IDbContext dbContext,IMapper mapper):IRequestHandler<GetSongDetailsQuery,SongVM>
{
    public async Task<SongVM> Handle(GetSongDetailsQuery query,CancellationToken cancellationToken)
    {
        Song? song = null;
        foreach (var item in dbContext.Songs)
        {
            if (item.Id == query.Id)
            {
                song = item;
                break;
            }
        }
        return mapper.Map<SongVM>(song);
    }
}

using AutoMapper;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;

namespace Content.Application.Albums.Queries.GetAlbumDetails;

public class GetAlbumDetailsQueryHandler(IDbContext dbContext,IMapper mapper):IRequestHandler<GetAlbumDetailsQuery,AlbumDetailsVM>
{
    public async Task<AlbumDetailsVM> Handle(GetAlbumDetailsQuery query,CancellationToken cancellationToken)
    {
        Album? album = null;
        foreach(var item in dbContext.Albums)
        {
            if(item.Id == query.Id)
            {
                album = item;
                break;
            }
        }
        return mapper.Map<AlbumDetailsVM>(album);
    }
}

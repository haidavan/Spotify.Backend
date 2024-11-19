

using MediatR;

namespace Content.Application.Albums.Queries.GetAlbumDetails;

public class GetAlbumDetailsQuery:IRequest<AlbumDetailsVM>
{
    public int Id {  get; set; }
}

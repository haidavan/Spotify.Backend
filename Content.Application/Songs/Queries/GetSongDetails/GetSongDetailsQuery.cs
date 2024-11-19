using MediatR;

namespace Content.Application.Songs.Queries.GetSongDetails;

public class GetSongDetailsQuery:IRequest<SongVM>
{
    public int Id { get; set; } 
}

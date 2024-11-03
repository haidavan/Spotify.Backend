using MediatR;

namespace Content.Application.Songs.Commands.DeleteSong;

public class DeleteSongCommand:IRequest
{
    public int Id { get; set; }
}

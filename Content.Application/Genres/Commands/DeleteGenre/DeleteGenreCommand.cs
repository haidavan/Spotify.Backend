using MediatR;

namespace Content.Application.Genres.Commands.DeleteGenre;

public class DeleteGenreCommand:IRequest
{
    public int Id { get; set; }
}

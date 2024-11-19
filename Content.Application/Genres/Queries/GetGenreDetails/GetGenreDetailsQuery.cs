

using MediatR;

namespace Content.Application.Genres.Queries.GetGenreDetails;

public class GetGenreDetailsQuery:IRequest<GenreVM>
{
    public int Id {  get; set; }
}

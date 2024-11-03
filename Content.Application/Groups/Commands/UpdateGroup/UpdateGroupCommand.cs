using Content.Domain;
using MediatR;

namespace Content.Application.Groups.Commands.UpdateGroup;

public class UpdateGroupCommand:IRequest
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string UrlImage { get; set; }
    public required List<Genre> Genres { get; set; }
}

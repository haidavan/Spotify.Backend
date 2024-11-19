

using Content.Domain;

namespace Content.Application.Groups.Queries.GetGroupDetails;

public class GroupVM
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string UrlImage { get; set; }
    public required List<Genre> Genres { get; set; }
}

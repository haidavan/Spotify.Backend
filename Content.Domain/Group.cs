using System.ComponentModel.DataAnnotations;

namespace Content.Domain;

public class Group
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string UrlImage { get; set; }
    public required List<Genre> Genres { get; set; }
}

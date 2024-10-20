namespace Content.Domain;

public class Song
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required List<Album> Albums { get; set; }

}

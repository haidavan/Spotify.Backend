namespace Content.Domain;

public class Album
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateOnly ReleaseDate { get; set; }
    public required List<Song> Songs { get; set; }
    public required List<Genre> Genres { get; set; }
}

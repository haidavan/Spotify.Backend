﻿namespace Content.Domain;

public class Genre
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required List<Group> Groups { get; set; }
    public required List<Album> Albums { get; set; }
}

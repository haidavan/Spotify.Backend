﻿using Content.Domain;
using MediatR;

namespace Content.Application.Songs.Commands.UpdateSong;

public class UpdateSongCommand:IRequest
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required List<Album> Albums { get; set; }
}
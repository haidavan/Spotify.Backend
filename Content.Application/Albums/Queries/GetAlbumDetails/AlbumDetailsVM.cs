using AutoMapper;
using Content.Application.Mapping;
using Content.Domain;

namespace Content.Application.Albums.Queries.GetAlbumDetails;

public class AlbumDetailsVM : IMapWith<Album>
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required DateOnly ReleaseDate { get; set; }
    public required List<Song> Songs { get; set; }
    public required List<Genre> Genres { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Album, AlbumDetailsVM>()
            .ForMember(albumVM => albumVM.Title,
                        opt => opt.MapFrom(album => album.Title))
             .ForMember(groupVM => groupVM.Description,
                        opt => opt.MapFrom(album => album.Description))
            .ForMember(albumVM => albumVM.ReleaseDate,
                        opt => opt.MapFrom(album => album.ReleaseDate))
            .ForMember(albumVM => albumVM.Songs,
                        opt => opt.MapFrom(album => album.Songs))
            .ForMember(albumVM => albumVM.Genres,
                        opt => opt.MapFrom(album => album.Genres));
    }
}

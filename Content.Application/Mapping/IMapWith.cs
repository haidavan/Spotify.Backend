using AutoMapper;
namespace Content.Application.Mapping;

public interface IMapWith<T>
{
    void Mapping(Profile profile)=>
        profile.CreateMap(typeof(T),GetType());
}

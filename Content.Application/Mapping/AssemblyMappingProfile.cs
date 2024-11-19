using AutoMapper;
using Content.Application.Mapping;
using System.Reflection;

namespace Content.Application.Mapping;

public class AssemblyMappingProfile : Profile
{
    public AssemblyMappingProfile(Assembly assembly) =>
             ApplyMappingsFromAssembly(assembly);

    private void ApplyMappingsFromAssembly(Assembly assembly)
    {
        var types = assembly.GetExportedTypes()
            .Where(type => type.GetInterfaces()
                .Any(i => i.IsGenericType &&
                i.GetGenericTypeDefinition() == typeof(IMapWith<>)))
            .ToList();
        IMapWith<object> dummy;
        foreach (var type in types)
        {
            var instance = Activator.CreateInstance(type);
            var methodInfo = type.GetMethod(nameof(dummy.Mapping));
            methodInfo?.Invoke(instance, [this]);
        }
    }
}
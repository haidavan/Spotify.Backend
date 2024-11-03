using Content.Application.Interfaces;
using MediatR;
using Content.Domain;

namespace Content.Application.Groups.Commands.CreateGroup;

public class CreateGroupCommandHandler(IDbContext DbContext):IRequestHandler<CreateGroupCommand,int>
{
    public async Task<int> Handle(CreateGroupCommand request,CancellationToken cancellationToken)
    {
        var group = new Group
        {
            Title = request.Title,
            Description = request.Description,
            Genres = request.Genres,
            UrlImage = request.UrlImage,
        };
        await DbContext.Groups.AddAsync(group);
        await DbContext.SaveChangesAsync(cancellationToken);
        return group.Id;
    }
}

using Content.Application.Exceptions;
using Content.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;

namespace Content.Application.Groups.Commands.UpdateGroup;

public class UpdateGroupCommandHandler(IDbContext dbContext):IRequestHandler<UpdateGroupCommand>
{
    public async Task Handle(UpdateGroupCommand request,CancellationToken cancellationToken)
    {
        var entity=await dbContext.Groups.FirstOrDefaultAsync(x=>x.Id==request.Id,cancellationToken) ??
            throw new NotFoundException(nameof(Group),request.Id);
        entity.Description = request.Description;
        entity.Title = request.Title;
        entity.Genres = request.Genres;
        entity.UrlImage = request.UrlImage;
        await dbContext.SaveChangesAsync(cancellationToken);
    }
}

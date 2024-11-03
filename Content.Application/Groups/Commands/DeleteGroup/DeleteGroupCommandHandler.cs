using Content.Application.Exceptions;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Content.Application.Groups.Commands.DeleteGroup;

public class DeleteGroupCommandHandler(IDbContext DbContext):IRequestHandler<DeleteGroupCommand>
{
    public async Task Handle(DeleteGroupCommand request,CancellationToken cancellationToken)
    {
        var group = await DbContext.Groups.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (group is null)
            throw new NotFoundException(nameof(Group), request.Id);
        DbContext.Groups.Remove(group);
        await DbContext.SaveChangesAsync(cancellationToken);
    }
}

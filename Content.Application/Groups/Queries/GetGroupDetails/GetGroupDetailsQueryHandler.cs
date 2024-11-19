
using AutoMapper;
using Content.Application.Interfaces;
using Content.Domain;
using MediatR;

namespace Content.Application.Groups.Queries.GetGroupDetails;

public class GetGroupDetailsQueryHandler(IDbContext dbContext,IMapper mapper):IRequestHandler<GetGroupDetailsQuery,GroupVM>
{
    public async Task<GroupVM> Handle(GetGroupDetailsQuery query,CancellationToken cancellationToken)
    {
        Group? group = null;
        foreach(var item in dbContext.Groups)
            if(item.Id == query.Id)
            {
                group = item;
                break;
            }
        return mapper.Map<GroupVM>(group);
    }
}

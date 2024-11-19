
using MediatR;

namespace Content.Application.Groups.Queries.GetGroupDetails;

public class GetGroupDetailsQuery:IRequest<GroupVM>
{
    public int Id {  get; set; }
}

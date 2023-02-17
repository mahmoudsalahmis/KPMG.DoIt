using MediatR;

namespace KPMG.DoIt.Application.Task.Query.GetTaskById
{
    public sealed record GetTaskByIdQuery(string Id) : IRequest<GetTaskByIdResponse> ;

}

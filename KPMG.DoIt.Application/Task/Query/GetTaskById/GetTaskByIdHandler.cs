using MediatR;

namespace KPMG.DoIt.Application.Task.Query.GetTaskById
{
    public sealed class GetTaskByIdHandler : IRequestHandler<GetTaskByIdQuery, GetTaskByIdResponse>
    {
        public async Task<GetTaskByIdResponse> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            await System.Threading.Tasks.Task.Delay(500, cancellationToken);

            return new GetTaskByIdResponse{ Id = "123", Name = "Test1", Description = "Description 1"};
        }
    }
}

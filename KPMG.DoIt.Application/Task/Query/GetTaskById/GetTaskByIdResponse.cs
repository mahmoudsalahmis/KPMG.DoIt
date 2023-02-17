namespace KPMG.DoIt.Application.Task.Query.GetTaskById
{
    public sealed record GetTaskByIdResponse
    {
        public required string Id { get; init; }
        public required string Name { get; init; }
        public required string Description { get; init; }
    }
}

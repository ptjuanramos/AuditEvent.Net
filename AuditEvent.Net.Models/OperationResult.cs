namespace AuditEvent.Net.Models
{
    public record OperationResult<T> : OperationResult
    {
        public T Result { get; init; }
    }

    public record OperationResult
    {
        public bool IsSuccess { get; init; }
        public string ErrorMessage { get; init; }
    }
}

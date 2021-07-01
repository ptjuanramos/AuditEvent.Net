namespace AuditEvent.Net.Models
{
    public record OperationResult<T>
    {
        public T Result { get; init; }
        public bool IsSuccess { get; init; }
        public string ErrorMessage { get; init; }
    }
}

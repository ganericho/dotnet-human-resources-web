namespace api.Utilities;

public class RepositoryResult <T>
{
    public bool IsFailed { get; set; }
    public string? Status { get; set; }
    public T? Data { get; set; }
}

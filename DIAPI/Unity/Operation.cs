namespace DIAPI.Unity;

public class Operation : IOperationScoped, IOperationTransient, IOperationSingleton
{
    public Operation()
    {
        OperationId = Guid.NewGuid().ToString()[^4..];
    }

    public string OperationId { get; }
}
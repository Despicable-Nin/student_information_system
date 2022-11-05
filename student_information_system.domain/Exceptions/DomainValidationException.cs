namespace student_information_system.domain.Exceptions;

public class DomainValidationException : Exception
{
    private readonly string _message;
    public DomainValidationException(string message) : base(message)
    {
        _message = message;
    }

    public DomainValidationException(string message, Exception innerException) : base(message, innerException)
    {
        _message = message;
    }

    public override string ToString()
    {
        return _message;
    }
}
namespace student_information_system.domain.Exceptions;

public class DomainValidationException : Exception
{
    public DomainValidationException(string? message) : base(message)
    {
    }

    public DomainValidationException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

   
}
namespace student_information_system.domain.Exceptions;

public class ErrorMessageConsts
{
    private const string BaseValidationMessage =
        $"Validation exception in {nameof(student_information_system.domain.SeedWork.Audit)}";
    
    public const string ValueCannotBeEmpty = $"{BaseValidationMessage} Value cannot be empty.";
}
using student_information_system.domain.SeedWork;

namespace student_information_system.domain.Exceptions;

public static class ErrorMessageConsts
{
    private const string BaseValidationMessage =
        $"Validation exception in {nameof(Audit)}";

    public const string ValueCannotBeEmpty = $"{BaseValidationMessage} Value cannot be empty.";
}
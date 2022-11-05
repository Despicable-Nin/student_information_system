using student_information_system.domain.SeedWork;

namespace student_information_system.domain.StudentAggregate;

internal sealed class PhoneNumber : Audit
{
    public string Number { get; private set; }
}


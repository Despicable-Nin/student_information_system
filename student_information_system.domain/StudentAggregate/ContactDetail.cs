using student_information_system.domain.SeedWork;

namespace student_information_system.domain.StudentAggregate;

internal sealed class ContactDetail : Audit
{
    private List<PhoneNumber> _phoneNumbers;

    public string Email { get; private set; }
    public IEnumerable<PhoneNumber> PhoneNumbers => _phoneNumbers.AsReadOnly();

    public string Address { get; private set; }
}


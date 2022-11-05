using student_information_system.domain.SeedWork;

namespace student_information_system.domain.AggregateModels.StudentAggregate;

internal class ContactDetail : Audit
{
    private readonly List<PhoneNumber> _phoneNumbers;

    protected ContactDetail()
    {
        _phoneNumbers = new List<PhoneNumber>();
    }

    public ContactDetail(string email, IEnumerable<PhoneNumber> phoneNumbers) : this()
    {
        Email = email;
        _phoneNumbers.AddRange(phoneNumbers);
    }

    public string Email { get; }

    public IEnumerable<PhoneNumber> PhoneNumbers => _phoneNumbers.AsReadOnly();
}
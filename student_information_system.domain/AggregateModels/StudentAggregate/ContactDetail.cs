using student_information_system.domain.SeedWork;
using student_information_system.domain.StudentAggregate;

namespace student_information_system.domain.AggregateModels.StudentAggregate;

internal class ContactDetail : Audit
{

    public string Email { get; private set; }
    
    private readonly List<PhoneNumber> _phoneNumbers;

    public IEnumerable<PhoneNumber> PhoneNumbers => _phoneNumbers.AsReadOnly();

    protected ContactDetail()
    {
        _phoneNumbers = new List<PhoneNumber>();
    }

    public ContactDetail(string email, IEnumerable<PhoneNumber> phoneNumbers) : this()
    {
        Email = email;
        _phoneNumbers.AddRange(phoneNumbers);
    }

}


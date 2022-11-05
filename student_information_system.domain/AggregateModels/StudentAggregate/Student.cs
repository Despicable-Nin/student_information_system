using student_information_system.domain.SeedWork;

namespace student_information_system.domain.AggregateModels.StudentAggregate;

internal sealed class Student : Entity, IAggregateRoot
{
    public Student(string lrn, string lastname, string firstname, string middlename, DateTimeOffset dob, Gender gender, Address address)
    {
        LRN = lrn;
        LastName = lastname;
        FirstName = firstname;
        MiddleName = middlename;
        DoB = dob;
        Gender = gender;
        Address = address;
    }

    public string LRN { get; }
    public string LastName { get; }
    public string FirstName { get; }
    public string MiddleName { get; }
    public DateTimeOffset DoB { get; }

    public Gender Gender { get; }

    public Address Address { get; }
}
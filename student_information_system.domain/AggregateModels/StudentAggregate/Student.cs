using student_information_system.domain.SeedWork;

namespace student_information_system.domain.AggregateModels.StudentAggregate;

public sealed class Student : Entity, IAggregateRoot
{
    public Student(string lrn, string lastname, string firstname, string middlename, DateTimeOffset dob, Gender gender, Address address)
    {
        Lrn = lrn;
        LastName = lastname;
        FirstName = firstname;
        MiddleName = middlename;
        DoB = dob;
        Gender = gender;
        Address = address;
    }

    public string Lrn { get; private set; }
    public string LastName { get; private set; }
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    public DateTimeOffset DoB { get; private set; }

    public Gender Gender { get; private set; }

    public Address Address { get; private set; }

    public void ChangeGender(Gender gender) => this.Gender = gender;
    public void ChangeLrn(string lrn) => this.Lrn = lrn;
    public void ChangeName(string lastName, string firstname, string middleName)
    {
        this.LastName = lastName;
        this.FirstName = firstname;
        this.MiddleName = middleName;
    }
    public void ChangeDateOfBirth(DateTimeOffset dob) => this.DoB = dob;
}
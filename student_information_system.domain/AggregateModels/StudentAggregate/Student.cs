using student_information_system.domain.SeedWork;

namespace student_information_system.domain.AggregateModels.StudentAggregate;

internal sealed class Student : Entity, IAggregateRoot
{
    public Student(string lrn, string lastname, string firstname, string middlename, Gender gender, Address address)
    {
        LRN = lrn;
        LastName = lastname;
        FirstName = firstname;
        MiddleName = middlename;
        Gender = gender;
        Address = address;
    }

    public string LRN { get; }
    public string LastName { get; }
    public string FirstName { get; }
    public string MiddleName { get; }

    public Gender Gender { get; }

    public Address Address { get; }
}

public class Address : ValueObject
{
    private Address()
    {
    }

    public Address(string street, string city, string state, string country, string zipcode)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipcode;
    }

    public string Street { get; }
    public string City { get; }
    public string State { get; }
    public string Country { get; }
    public string ZipCode { get; }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        // Using a yield return statement to return each element one at a time
        yield return Street;
        yield return City;
        yield return State;
        yield return Country;
        yield return ZipCode;
    }
}
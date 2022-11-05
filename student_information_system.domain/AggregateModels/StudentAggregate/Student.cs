using student_information_system.domain.SeedWork;

namespace student_information_system.domain.StudentAggregate;

internal sealed class Student : Entity, IAggregateRoot
{
    
    public string LRN { get; private set; }
    public string LastName { get; private set; }
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }
    
    public Gender Gender { get; private set; }
    
    public Address Address { get; private set; }

    public Student(string lrn, string lastname, string firstname, string middlename, Gender gender, Address address)
    {
        LRN = lrn;
        LastName = lastname;
        FirstName = firstname;
        MiddleName = middlename;
        Gender = gender;
        Address = address;
    }

}

public class Address : ValueObject
{
    public String Street { get; private set; }
    public String City { get; private set; }
    public String State { get; private set; }
    public String Country { get; private set; }
    public String ZipCode { get; private set; }
    

    private Address(){}
    public Address(string street, string city, string state, string country, string zipcode)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
        ZipCode = zipcode;
    }

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


namespace student_information.app.Models.StudentModels;

public class StudentCreateViewModel
{
    public string LRN { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string AddressLine { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public DateTimeOffset DateOfBirth { get; set; }
    public int Gender { get; set; }
    
}
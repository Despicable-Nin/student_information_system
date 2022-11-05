using student_information_system.domain.SeedWork;

namespace student_information_system.domain.StudentAggregate;

internal sealed class Student : Audit
{
    
    public string LRN { get; private set; }
    public string LastName { get; private set; }
    public string FirstName { get; private set; }
    public string MiddleName { get; private set; }

}


namespace student_information.app.Models.StudentModels;

public record StudentListViewModel
{
    public string LRN { get; private set; }
    public string FullName { get; private set; }
    public string DateOfBirth { get; private set; }
    public string Email { get; private set; }
    public string Address { get; private set; }
    public string ContactNumber { get; private set; }
   
        
        
}
using Microsoft.EntityFrameworkCore;
using student_information_system.domain.SeedWork;

namespace student_information_system.infrastructure;

public class StudentContext : DbContext, IUnitOfWork
{
    public const string DEFAULT_SCHEMA = "student_monitoring";
    public Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
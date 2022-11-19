using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using student_information_system.domain.AggregateModels.StudentAggregate;

namespace student_information_system.infrastructure.EntityConfigurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("students", StudentContext.DEFAULT_SCHEMA);
        builder.HasKey(b => b.Id);
        builder.Ignore(b => b.DomainEvents);
        builder.Property(b => b.Id).UseHiLo("studentseq", StudentContext.DEFAULT_SCHEMA);
        builder.Property(b => b.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(b => b.LastName).IsRequired().HasMaxLength(100);

        builder.Property(b => b.Gender).IsRequired();
    }
}
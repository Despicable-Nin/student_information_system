using student_information_system.domain.Exceptions;

namespace student_information_system.domain.SeedWork;

public abstract class Audit : IAuditable
{
    private string _createdBy;

    private string _modifiedBy;
    public DateTimeOffset CreatedOn { get; private set; }
    public DateTimeOffset ModifiedOn { get; private set; }

    public string CreatedBy
    {
        get => _createdBy;
        private set
        {
            if (string.IsNullOrWhiteSpace(_createdBy))
                throw new DomainValidationException(ErrorMessageConsts.ValueCannotBeEmpty);

            _createdBy = value.ToLower();
        }
    }

    public string ModifiedBy
    {
        get => _modifiedBy;
        private set
        {
            if (string.IsNullOrWhiteSpace(_modifiedBy))
                throw new DomainValidationException(ErrorMessageConsts.ValueCannotBeEmpty);

            _modifiedBy = value.ToLower();
        }
    }

    public virtual void AuditOnCreate(string createdBy)
    {
        CreatedBy = createdBy;
        ModifiedBy = createdBy;

        var now = DateTimeOffset.Now;
        CreatedOn = now;
        ModifiedOn = now;
    }

    public virtual void AuditOnModify(string modifiedBy)
    {
        ModifiedBy = modifiedBy;
        ModifiedOn = DateTimeOffset.Now;
    }
}

public interface IAuditable
{
    public DateTimeOffset CreatedOn { get; }
    public DateTimeOffset ModifiedOn { get; }

    public string CreatedBy { get; }
    public string ModifiedBy { get; }
}
using CMSWorkflowService.Domain.Enum;

namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatus: Entity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public WorkflowStatusType Type { get; set; }
    public WorkflowStatusOwner Owner { get; set; }

    public int? ParentId { get; set; }

    public Guid? ParentUuid { get; set; }
    public virtual ICollection<WorkflowStatusDetail> WorkflowStatusDetails { get; set; } = new List<WorkflowStatusDetail>();

    public virtual ICollection<WorkflowStatusEmail> WorkflowStatusEmails { get; set; } = new List<WorkflowStatusEmail>();

    public virtual ICollection<WorkflowStatusRole> WorkflowStatusRoles { get; set; } = new List<WorkflowStatusRole>();

    public virtual ICollection<WorkflowStatusTransaction> WorkflowStatusTransactions { get; set; } = new List<WorkflowStatusTransaction>();

    public virtual ICollection<WorkflowStatusUser> WorkflowStatusUsers { get; set; } = new List<WorkflowStatusUser>();
}

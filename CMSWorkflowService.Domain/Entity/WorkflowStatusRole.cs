using CMSWorkflowService.Domain.Enum;

namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusRole: Entity
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusId { get; set; }

    public WorkflowStatusRoleType Type { get; set; }

    public Guid RoleId { get; set; }
    public virtual WorkflowStatus WorkflowStatus { get; set; } = null!;
}

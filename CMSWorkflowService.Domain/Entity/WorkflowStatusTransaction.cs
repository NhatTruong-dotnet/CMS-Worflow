namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusTransaction: Entity
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusToId { get; set; }

    public Guid WorkflowStatusFromId { get; set; }

    public bool? IsDeleted { get; set; }
    public virtual WorkflowStatus WorkflowStatusTo { get; set; } = null!;

}

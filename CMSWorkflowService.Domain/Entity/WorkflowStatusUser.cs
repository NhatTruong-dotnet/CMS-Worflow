namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusUser: Entity
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusId { get; set; }

    public Guid UserId { get; set; }
    public virtual WorkflowStatus WorkflowStatus { get; set; } = null!;

}

namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusTransaction
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusToId { get; set; }

    public Guid WorkflowStatusFromId { get; set; }

    public bool? IsDeleted { get; set; }
}

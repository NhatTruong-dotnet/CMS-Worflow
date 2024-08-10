namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusUser
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusId { get; set; }

    public Guid UserId { get; set; }
}

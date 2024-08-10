namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusRole
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusId { get; set; }

    public int Type { get; set; }

    public Guid RoleId { get; set; }
}

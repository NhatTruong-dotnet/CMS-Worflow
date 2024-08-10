namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusEmailReceiver
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusEmailId { get; set; }

    public int Type { get; set; }

    public string Email { get; set; } = null!;

    public string DisplayName { get; set; } = null!;
}

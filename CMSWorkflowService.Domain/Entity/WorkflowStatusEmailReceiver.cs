using CMSWorkflowService.Domain.Enum;

namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusEmailReceiver: Entity
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusEmailId { get; set; }

    public WorkflowStatusEmailReceiverType Type { get; set; }

    public string Email { get; set; } = null!;

    public string DisplayName { get; set; } = null!;
    public virtual WorkflowStatusEmail IdNavigation { get; set; } = null!;
}

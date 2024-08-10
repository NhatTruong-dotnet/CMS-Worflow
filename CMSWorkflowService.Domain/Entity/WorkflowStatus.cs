namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatus
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public int Type { get; set; }

    public int? ParentId { get; set; }

    public Guid? ParentUuid { get; set; }
}

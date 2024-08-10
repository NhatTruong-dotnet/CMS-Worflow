namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusDetail
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusId { get; set; }

    public bool IsRequiredAttachment { get; set; }

    public string TemplateUrl { get; set; } = null!;

    public string TemplateFileName { get; set; } = null!;

    public bool IsRequiredDescription { get; set; }

    public string DescriptionLabel { get; set; } = null!;
}

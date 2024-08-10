namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusEmail
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusId { get; set; }

    public Guid EmailTemplateCode { get; set; }

    public int Type { get; set; }

    public int DailyType { get; set; }

    public long? TimeSendEmail { get; set; }

    public bool? TimeScheduleSendEmail { get; set; }

    public long? StartTime { get; set; }

    public long? EndTime { get; set; }
}

using CMSWorkflowService.Domain.Enum;

namespace CMSWorkflowService.Domain.Entity;

public partial class WorkflowStatusEmail: Entity
{
    public Guid Id { get; set; }

    public Guid WorkflowStatusId { get; set; }

    public Guid EmailTemplateCode { get; set; }

    //"Loại hình gửi: Ngay lập tức, hàng ngày"
    public WorkflowStatusEmailType Type { get; set; }

    //"Gửi theo thời gian cố định hay gom theo giờ gửi 1 lần"
    public WorkflowStatusEmailDailyType? DailyType { get; set; }

    public long? TimeSendEmail { get; set; }

    public bool? TimeScheduleSendEmail { get; set; }

    public long? StartTime { get; set; }

    public long? EndTime { get; set; }
    public virtual WorkflowStatus WorkflowStatus { get; set; } = null!;

}

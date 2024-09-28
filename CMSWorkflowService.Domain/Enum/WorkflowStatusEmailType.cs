using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CMSWorkflowService.Domain.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkflowStatusEmailType
    {
        [Description("Ngay lập tức")]
        Immediately = 1,
        [Description("Hàng ngày")]
        Daily = 2
    }
}

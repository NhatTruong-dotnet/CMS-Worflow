using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CMSWorkflowService.Domain.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkflowStatusEmailDailyType
    {
        [Description("Thời gian cố định")]
        SetTime = 1,
        [Description("Gom theo giờ")]
        Schedule = 2
    }
}

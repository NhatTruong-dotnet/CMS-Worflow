using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CMSWorkflowService.Domain.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkflowStatusOwner
    {
        [Description("Mua hàng")]
        Purchase = 1,
        [Description("Nhân sự")]
        HR = 2
    }

}

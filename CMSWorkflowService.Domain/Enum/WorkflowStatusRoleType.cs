using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CMSWorkflowService.Domain.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]

    public enum WorkflowStatusRoleType
    {

        [Description("Mua hàng")]
        Purchase = 1,
        [Description("Nhân sự")]
        HR = 2
    }
}

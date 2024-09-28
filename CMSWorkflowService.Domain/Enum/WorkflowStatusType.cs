using System.ComponentModel;
using System.Text.Json.Serialization;

namespace CMSWorkflowService.Domain.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum WorkflowStatusType
    {
        [Description("Phone Screen")]
        PhoneScreen = 1,
        [Description("Interview")]
        Interview = 2,
        [Description("Offer Made")]
        OfferMade = 3,
        [Description("Not Suitable")]
        NotSuitable = 4
    }
}

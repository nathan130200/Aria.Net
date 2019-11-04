using System.Runtime.Serialization;

namespace Aria.Net.Entities.Download
{
    public enum AriaDownloadStatus
    {
        [EnumMember(Value = "active")]
        Active,

        [EnumMember(Value = "waiting")]
        Waiting,

        [EnumMember(Value = "paused")]
        Paused,

        [EnumMember(Value = "error")]
        Errored,

        [EnumMember(Value = "complete")]
        Completed,

        [EnumMember(Value = "removed")]
        Removed,
    }
}

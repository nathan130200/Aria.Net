using System.Runtime.Serialization;

namespace Aria.Net.Entities.Download
{
	public enum AriaDownloadPosition
    {
		[EnumMember(Value = "POS_CUR")]
		Current,

		[EnumMember(Value = "POS_SET")]
		Set,

		[EnumMember(Value = "POS_END")]
		End
    }
}

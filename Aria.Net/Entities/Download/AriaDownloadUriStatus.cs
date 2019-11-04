using System.Runtime.Serialization;

namespace Aria.Net.Entities.Download
{
	public enum AriaDownloadUriStatus
	{
		[EnumMember(Value = "used")]
		Used,

		[EnumMember(Value = "waiting")]
		Waiting
	}
}

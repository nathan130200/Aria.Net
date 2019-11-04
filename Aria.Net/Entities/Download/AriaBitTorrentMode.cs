using System.Runtime.Serialization;

namespace Aria.Net.Entities.Download
{
	public enum AriaBitTorrentMode
	{
		[EnumMember(Value = "single")]
		Single,

		[EnumMember(Value = "multi")]
		Multi
	}
}

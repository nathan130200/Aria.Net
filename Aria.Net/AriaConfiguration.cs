namespace Aria.Net
{
	public class AriaConfiguration
	{
		/// <summary>
		/// IP or DNS name of the server on which the RPC for Aria2 is running (default: 127.0.0.1)
		/// </summary>
		public string Host { internal get; set; } = "127.0.0.1";

		/// <summary>
		/// Port of the server on which the RPC for Aria2 is running (default: 6800)
		/// </summary>
		public int Port { internal get; set; } = 6800;

		/// <summary>
		/// Enable SSL/TLS encryption
		/// </summary>
		public bool IsSecure { internal get; set; } = false;

		/// <summary>
		/// Enable Aria2 RPC authentication (default: false)
		/// </summary>
		public bool UseAuthentication { internal get; set; } = false;

		/// <summary>
		/// Aria2 RPC authentication token (default: empty)
		/// </summary>
		public string Token { internal get; set; } = string.Empty;
	}
}

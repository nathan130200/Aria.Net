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
        /// Aria2 RPC secret token (leave empty if authentication is not enabled)
        /// </summary>
        public bool UseAuthentication { internal get; set; } = false;

        /// <summary>
        /// Aria2 RPC token (empty if authentication not enabled)
        /// </summary>
        public string Token { internal get; set; } = string.Empty;

        /// <summary>
        /// Aria2 RPC username (empty if authentication not enabled)
        /// </summary>
        public string Username { internal get; set; } = string.Empty;

        /// <summary>
        /// Aria2 RPC password (empty if authentication not enabled)
        /// </summary>
        public string Password { internal get; set; } = string.Empty;
    }
}

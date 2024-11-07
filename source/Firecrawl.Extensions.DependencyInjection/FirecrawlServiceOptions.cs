using System;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class FirecrawlServiceOptions
	{
		/// <summary>
		/// 
		/// </summary>
		public Uri BaseUrl { get; set; } =
			FirecrawlService.DefaultBaseUrl;

		/// <summary>
		/// 
		/// </summary>
		public string ApiKey { get; set; }
	}
}

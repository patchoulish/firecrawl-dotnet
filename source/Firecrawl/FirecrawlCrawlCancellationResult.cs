using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlCrawlCancellationResult :
		FirecrawlResult
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"success")]
		public bool Success { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"message")]
		public string Message { get; init; }
	}
}

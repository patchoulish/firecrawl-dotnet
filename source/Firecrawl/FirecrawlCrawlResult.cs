using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlCrawlResult :
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
			"id")]
		public string Id { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"url")]
		public string Url { get; init; }
	}
}

using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlCreditUsageResult :
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
			"data")]
		public FirecrawlCreditUsageData Data { get; init; }
	}
}

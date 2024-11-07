using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections;
using System.Collections.Immutable;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlBatchScrapeStatusResult :
		FirecrawlResult
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"status")]
		public FirecrawlStatus Status { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"total")]
		public int TotalPageCount { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"completed")]
		public int CompletedPageCount { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"creditsUsed")]
		public int CreditsUsed { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"expiresAt")]
		public DateTime ExpiresAt { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"next")]
		public Uri NextUrl {  get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"data")]
		public ImmutableArray<FirecrawlScrapeData> Data { get; init; }
	}
}

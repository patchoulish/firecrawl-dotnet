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
	public class FirecrawlScrapeOptions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"url")]
		public Uri Url { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"formats")]
		public ImmutableArray<FirecrawlFormat> Formats { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"onlyMainContent")]
		public bool? OnlyMainContent { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"includeTags")]
		public ImmutableArray<string> IncludedTags { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"excludeTags")]
		public ImmutableArray<string> ExcludedTags { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"headers")]
		public ImmutableDictionary<string, string> Headers { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"waitFor")]
		public int? DelayInMilliseconds { get; init; }

		/// <summary>
		/// 
		/// </summary>

		[JsonPropertyName(
			"mobile")]
		public bool? EmulateMobileDevice { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"skipTlsVerification")]
		public bool? SkipTlsVerification { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"timeout")]
		public int? TimeoutInMilliseconds { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"extract")]
		public FirecrawlExtract Extract { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"actions")]
		public ImmutableArray<FirecrawlAction> Actions { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"location")]
		public FirecrawlLocation Location { get; init; }
	}
}

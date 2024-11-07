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
	public class FirecrawlCrawlScrape
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"formats")]
		public ImmutableArray<FirecrawlFormat> Formats { get; init; } =
			ImmutableArray<FirecrawlFormat>.Empty;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"headers")]
		public ImmutableDictionary<string, string> Headers { get; init; } =
			ImmutableDictionary<string, string>.Empty;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"includeTags")]
		public ImmutableArray<string> IncludedTags { get; init; } =
			ImmutableArray<string>.Empty;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"excludeTags")]
		public ImmutableArray<string> ExcludedTags { get; init; } =
			ImmutableArray<string>.Empty;

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
			"waitFor")]
		public int? DelayInMilliseconds { get; init; }
	}
}

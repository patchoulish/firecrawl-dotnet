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
	public class FirecrawlCrawlOptions
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
			"includePaths")]
		public ImmutableArray<string> IncludedPaths { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"excludePaths")]
		public ImmutableArray<string> ExcludedPaths { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"maxDepth")]
		public int? MaxDepth { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"ignoreSitemap")]
		public bool? IgnoreSitemap { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"limit")]
		public int? Limit { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"allowBackwardLinks")]
		public bool? AllowBackwardLinks { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"allowExternalLinks")]
		public bool? AllowExternalLinks { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"webhook")]
		public Uri WebhookUrl { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"scrapeOptions")]
		public FirecrawlCrawlScrape Scrape { get; init; }
	}
}

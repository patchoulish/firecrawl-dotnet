using System;
using System.Collections.Immutable;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlSearchData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"url")]
		public Uri Url { get; init; }

		[JsonPropertyName(
			"title")]
		public string Title { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"description")]
		public string Description { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"html")]
		public string Html { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"rawHtml")]
		public string HtmlRaw { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"markdown")]
		public string Markdown { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"links")]
		public ImmutableArray<string> Links { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"screenshot")]
		public string Screenshot { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"metadata")]
		public FirecrawlSearchDataMetadata Metadata { get; init; }
	}
}

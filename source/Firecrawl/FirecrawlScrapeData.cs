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
	public class FirecrawlScrapeData
	{
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
			"screenshot")]
		public string Screenshot { get; init; }

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
			"actions")]
		public FirecrawlScrapeDataActions Actions { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"metadata")]
		public FirecrawlScrapeDataMetadata Metadata { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"llm_extraction")]
		public JsonElement? Extract {  get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"warning")]
		public string ExtractWarning { get; init; }
	}
}

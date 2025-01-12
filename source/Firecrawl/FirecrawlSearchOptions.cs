using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlSearchOptions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"query")]
		public string Query { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"country")]
		public string Country { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"lang")]
		public string Language { get; init; }

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
			"location")]
		public string Location { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"scrapeOptions")]
		public FirecrawlSearchScrape Scrape { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"tbs")]
		public string Tbs { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"timeout")]
		public int? TimeoutInMilliseconds { get; init; }
	}
}

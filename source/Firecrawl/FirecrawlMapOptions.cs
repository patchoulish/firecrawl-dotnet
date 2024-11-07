using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlMapOptions
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
			"search")]
		public string Query { get; init; }

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
			"includeSubdomains")]
		public bool? IncludeSubdomains { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"limit")]
		public int? Limit { get; init; }
	}
}

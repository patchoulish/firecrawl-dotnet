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
	public sealed class FirecrawlScrapeDataMetadata
	{
		/// <summary>
		/// 
		/// </summary>
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
			"language")]
		public string Language { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"sourceURL")]
		public string SourceUrl { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"statusCode")]
		public int StatusCode { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"error")]
		public string ErrorMessage { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonExtensionData]
		public ImmutableDictionary<string, string> Extra { get; init; }
	}
}

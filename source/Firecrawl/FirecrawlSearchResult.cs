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
	public class FirecrawlSearchResult :
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
		public ImmutableArray<FirecrawlSearchData> Data { get; init; } =
			new ImmutableArray<FirecrawlSearchData>();

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"warning")]
		public string Warning { get; init; }
	}
}

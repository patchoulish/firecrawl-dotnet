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
	public class FirecrawlSearchScrape
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"formats")]
		public ImmutableArray<FirecrawlFormat> Formats { get; init; } =
			ImmutableArray<FirecrawlFormat>.Empty;
	}
}

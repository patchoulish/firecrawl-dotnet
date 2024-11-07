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
	public class FirecrawlLocation
	{
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
			"languages")]
		public ImmutableArray<string> Languages { get; init; }
	}
}

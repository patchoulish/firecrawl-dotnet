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
	public sealed class FirecrawlScrapeDataActions
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"screenshots")]
		public ImmutableArray<string> ScreenshotUrls { get; init; }
	}
}

using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlScreenshotAction :
		FirecrawlAction
	{
		/// <summary>
		/// 
		/// </summary>
		public override FirecrawlActionType Type { get; init; } =
			FirecrawlActionType.Screenshot;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"fullPage")]
		public bool IsFullPage { get; init; }
	}
}

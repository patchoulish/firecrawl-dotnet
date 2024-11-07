using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlScrollAction :
		FirecrawlAction
	{
		/// <summary>
		/// 
		/// </summary>
		public override FirecrawlActionType Type { get; init; } =
			FirecrawlActionType.Scroll;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"direction")]
		public FirecrawlScrollDirection Direction { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"amount")]
		public int AmountInPixels { get; init; }
	}
}

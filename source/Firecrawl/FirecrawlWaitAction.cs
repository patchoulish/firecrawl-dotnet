using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlWaitAction :
		FirecrawlAction
	{
		/// <summary>
		/// 
		/// </summary>
		public override FirecrawlActionType Type { get; init; } =
			FirecrawlActionType.Wait;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"selector")]
		public string Selector { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"milliseconds")]
		public int AmountInMilliseconds { get; init; }
	}
}

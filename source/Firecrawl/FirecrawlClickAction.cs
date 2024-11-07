using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlClickAction :
		FirecrawlAction
	{
		/// <summary>
		/// 
		/// </summary>
		public override FirecrawlActionType Type { get; init; } =
			FirecrawlActionType.Click;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"selector")]
		public string Selector { get; init; }
	}
}

using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlPressAction :
		FirecrawlAction
	{
		/// <summary>
		/// 
		/// </summary>
		public override FirecrawlActionType Type { get; init; } =
			FirecrawlActionType.Press;

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"key")]
		public string Key{ get; init; }
	}
}

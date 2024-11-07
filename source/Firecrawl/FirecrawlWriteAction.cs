using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlWriteAction :
		FirecrawlAction
	{
		/// <summary>
		/// 
		/// </summary>
		public override FirecrawlActionType Type { get; init; } =
			FirecrawlActionType.Write;

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
			"text")]
		public string Value { get; init; }
	}
}

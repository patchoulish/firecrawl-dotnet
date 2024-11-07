using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlExtract
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"schema")]
		public JsonElement? Schema { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"prompt")]
		public string Prompt { get; init; }

		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"systemPrompt")]
		public string PromptForSystem { get; init; }
	}
}

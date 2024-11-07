using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	[JsonPolymorphic(
		TypeDiscriminatorPropertyName = "type")]
	[JsonDerivedType(
		typeof(FirecrawlWaitAction),
		"wait")]
	[JsonDerivedType(
		typeof(FirecrawlScreenshotAction),
		"screenshot")]
	[JsonDerivedType(
		typeof(FirecrawlClickAction),
		"click")]
	[JsonDerivedType(
		typeof(FirecrawlWriteAction),
		"write")]
	[JsonDerivedType(
		typeof(FirecrawlPressAction),
		"press")]
	[JsonDerivedType(
		typeof(FirecrawlScrollAction),
		"scroll")]
	public class FirecrawlAction
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"type")]
		public virtual FirecrawlActionType Type { get; init; }
	}
}

using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonStringEnumConverter<FirecrawlFormat>))]
	public enum FirecrawlFormat
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"markdown")]
		Markdown,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"html")]
		Html,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"rawHtml")]
		HtmlRaw,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"links")]
		Links,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"screenshot")]
		Screenshot,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"screenshot@fullPage")]
		ScreenshotFullPage,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"extract")]
		Extract,
	}
}

using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Runtime;
using System.Runtime.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	[JsonConverter(
		typeof(JsonEnumMemberEnumConverter<FirecrawlFormat>))]
	public enum FirecrawlFormat
	{
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "markdown")]
		Markdown,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "html")]
		Html,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "rawHtml")]
		HtmlRaw,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "links")]
		Links,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "screenshot")]
		Screenshot,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "screenshot@fullPage")]
		ScreenshotFullPage,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "extract")]
		Extract,
	}
}

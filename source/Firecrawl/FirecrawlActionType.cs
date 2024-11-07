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
		typeof(JsonEnumMemberEnumConverter<FirecrawlActionType>))]
	public enum FirecrawlActionType
	{
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "wait")]
		Wait,

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
			Value = "click")]
		Click,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "write")]
		Write,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "press")]
		Press,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "scroll")]
		Scroll,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "scrape")]
		Scrape,
	}
}

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
		typeof(JsonStringEnumConverter<FirecrawlActionType>))]
	public enum FirecrawlActionType
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"wait")]
		Wait,

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
			"click")]
		Click,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"write")]
		Write,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"press")]
		Press,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"scroll")]
		Scroll,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"scrape")]
		Scrape,
	}
}

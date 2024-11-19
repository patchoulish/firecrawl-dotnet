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
		typeof(JsonStringEnumConverter<FirecrawlStatus>))]
	public enum FirecrawlStatus
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"scraping")]
		InProgress,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"completed")]
		Completed,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"failed")]
		Failed,
	}
}

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
		typeof(JsonEnumMemberEnumConverter<FirecrawlStatus>))]
	public enum FirecrawlStatus
	{
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "scraping")]
		InProgress,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "completed")]
		Completed,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "failed")]
		Failed,
	}
}

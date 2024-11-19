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
	public enum FirecrawlScrollDirection
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"up")]
		Up,

		/// <summary>
		/// 
		/// </summary>
		[JsonStringEnumMemberName(
			"down")]
		Down,
	}
}

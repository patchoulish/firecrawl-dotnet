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
	public enum FirecrawlScrollDirection
	{
		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "up")]
		Up,

		/// <summary>
		/// 
		/// </summary>
		[EnumMember(
			Value = "down")]
		Down,
	}
}

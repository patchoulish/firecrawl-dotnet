using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlCreditUsageData
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"remaining_credits")]
		public int CreditsRemaining { get; set; }
	}
}

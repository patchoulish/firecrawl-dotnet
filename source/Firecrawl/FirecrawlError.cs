﻿using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlError
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonPropertyName(
			"error")]
		public string Message { get; init; }
	}
}
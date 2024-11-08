using System;

using Microsoft;
using Microsoft.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Firecrawl
{
	/// <summary>
	/// Represents the options when registering an instance of the <see cref="FirecrawlService"/>
	/// class with an <see cref="IServiceCollection"/>.
	/// </summary>
	public sealed class FirecrawlServiceOptions
	{
		/// <summary>
		/// Gets or sets the base URL to use.
		/// </summary>
		public Uri BaseUrl { get; set; } =
			FirecrawlService.DefaultBaseUrl;

		/// <summary>
		/// Gets or sets the API key to use.
		/// </summary>
		public string ApiKey { get; set; }
	}
}

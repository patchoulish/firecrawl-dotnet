using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using Microsoft;
using Microsoft.Extensions;
using Microsoft.Extensions.DependencyInjection;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public static class ServiceCollectionExtensions
	{
		/// <summary>
		/// 
		/// </summary>
		private const string FirecrawlHttpClientName =
			"firecrawl";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="services"></param>
		/// <param name="optionsCallback"></param>
		/// <returns></returns>
		public static IHttpClientBuilder AddFirecrawlHttpClient(
			this IServiceCollection services,
			Action<FirecrawlServiceOptions> optionsCallback = default)
		{
			Guard.NotNull(
				services,
				nameof(services));

			var options =
				new FirecrawlServiceOptions();

			return services
				.AddHttpClient<IFirecrawlService, FirecrawlService>(
					FirecrawlHttpClientName,
					(httpClient) =>
					{
						// Configure the base URL for the client.
						httpClient.BaseAddress =
							options.BaseUrl;

						// Configure the default request headers for the client.
						httpClient.DefaultRequestHeaders.Authorization =
							new AuthenticationHeaderValue(
								"Bearer",
								options.ApiKey);
					});
		}
	}
}

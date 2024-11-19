using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public sealed class FirecrawlService :
		IFirecrawlService
	{
		/// <summary>
		/// Gets the default base URL for the Firecrawl API.
		/// </summary>
		public static Uri DefaultBaseUrl { get; } =
			new Uri(
				"https://api.firecrawl.dev/v1/");

		/// <summary>
		/// The JSON serializer options for serializing and deserializing JSON data.
		/// </summary>
		internal static JsonSerializerOptions JsonSerializerOptions { get; } =
			new JsonSerializerOptions()
			{
				DefaultIgnoreCondition =
					JsonIgnoreCondition.WhenWritingNull
			};

		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseUrl"></param>
		/// <param name="apiKey"></param>
		/// <returns></returns>
		private static HttpClient CreateClient(
			Uri baseUrl,
			string apiKey)
		{
			Guard.NotNull(
				baseUrl,
				nameof(baseUrl));

			Guard.NotNullOrEmpty(
				apiKey,
				nameof(apiKey));

			var httpClient =
				new HttpClient(
					new FirecrawlDelegatingHandler()
					{
						InnerHandler = new HttpClientHandler()
					},
					disposeHandler: true);

			httpClient.BaseAddress =
				baseUrl;

			httpClient.DefaultRequestHeaders.Add(
				$"Authorization",
				$"Bearer {apiKey}");

			return httpClient;
		}

		private readonly HttpClient httpClient;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="apiKey"></param>
		public FirecrawlService(
			string apiKey) :
				this(
					DefaultBaseUrl,
					apiKey)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="baseUrl"></param>
		/// <param name="apiKey"></param>
		public FirecrawlService(
			Uri baseUrl,
			string apiKey) :
				this(
					CreateClient(
						baseUrl,
						apiKey))
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="httpClient"></param>
		public FirecrawlService(
			HttpClient httpClient)
		{
			Guard.NotNull(
				httpClient,
				nameof(httpClient));

			this.httpClient = httpClient;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<FirecrawlScrapeResult> ScrapeAsync(
			FirecrawlScrapeOptions options,
			CancellationToken cancellationToken = default)
		{
			Guard.NotNull(
				options,
				nameof(options));

			// Serialize and POST the request...
			var response =
				await this.httpClient
					.PostAsJsonAsync(
						$"scrape",
						options,
						JsonSerializerOptions,
						cancellationToken);

			// ...then deserialize the response and return the result.
			return await response.Content
				.ReadFromJsonAsync<FirecrawlScrapeResult>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<FirecrawlCrawlResult> CrawlAsync(
			FirecrawlCrawlOptions options,
			CancellationToken cancellationToken = default)
		{
			Guard.NotNull(
				options,
				nameof(options));

			// Serialize and POST the request...
			var response =
				await this.httpClient
					.PostAsJsonAsync(
						$"crawl",
						options,
						JsonSerializerOptions,
						cancellationToken);

			// ...then deserialize the response and return the result.
			return await response.Content
				.ReadFromJsonAsync<FirecrawlCrawlResult>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<FirecrawlCrawlStatusResult> GetCrawlStatusAsync(
			string id,
			CancellationToken cancellationToken = default)
		{
			Guard.NotNullOrEmpty(
				id,
				nameof(id));

			return await this.httpClient
				.GetFromJsonAsync<FirecrawlCrawlStatusResult>(
					$"crawl/{id}",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<FirecrawlCrawlCancellationResult> CancelCrawlAsync(
			string id,
			CancellationToken cancellationToken = default)
		{
			Guard.NotNullOrEmpty(
				id,
				nameof(id));

			return await this.httpClient
				.DeleteFromJsonAsync<FirecrawlCrawlCancellationResult>(
					$"crawl/{id}",
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<FirecrawlMapResult> MapAsync(
			FirecrawlMapOptions options,
			CancellationToken cancellationToken = default)
		{
			Guard.NotNull(
				options,
				nameof(options));

			// Serialize and POST the request...
			var response =
				await this.httpClient
					.PostAsJsonAsync(
						$"map",
						options,
						JsonSerializerOptions,
						cancellationToken);

			// ...then deserialize the response and return the result.
			return await response.Content
				.ReadFromJsonAsync<FirecrawlMapResult>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<FirecrawlBatchScrapeResult> BatchScrapeAsync(
			FirecrawlBatchScrapeOptions options,
			CancellationToken cancellationToken = default)
		{
			Guard.NotNull(
				options,
				nameof(options));

			// Serialize and POST the request...
			var response =
				await this.httpClient
					.PostAsJsonAsync(
						$"batch/scrape",
						options,
						JsonSerializerOptions,
						cancellationToken);

			// ...then deserialize the response and return the result.
			return await response.Content
				.ReadFromJsonAsync<FirecrawlBatchScrapeResult>(
					JsonSerializerOptions,
					cancellationToken);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<FirecrawlBatchScrapeStatusResult> GetBatchScrapeStatusAsync(
			string id,
			CancellationToken cancellationToken = default)
		{
			Guard.NotNullOrEmpty(
				id,
				nameof(id));

			return await this.httpClient
				.GetFromJsonAsync<FirecrawlBatchScrapeStatusResult>(
					$"batch/scrape/{id}",
					JsonSerializerOptions,
					cancellationToken);
		}
	}
}

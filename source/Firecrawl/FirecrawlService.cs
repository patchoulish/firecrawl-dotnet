using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using System.Net.Http.Json;
using System.Net;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

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
		/// 
		/// </summary>
		private static JsonSerializerOptions JsonSerializerOptions { get; } =
			new JsonSerializerOptions()
			{

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
			ArgumentNullException
				.ThrowIfNull(
					baseUrl,
					nameof(baseUrl));

			ArgumentException
				.ThrowIfNullOrEmpty(
					apiKey,
					nameof(apiKey));

			var client =
				new HttpClient();

			client.BaseAddress =
				baseUrl;

			client.DefaultRequestHeaders.Authorization =
				new AuthenticationHeaderValue(
					"Bearer",
					apiKey);

			return client;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="TResult"></typeparam>
		/// <param name="response"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		/// <exception cref="FirecrawlException"></exception>
		private static async Task<TResult> ProcessResponseAsync<TResult>(
			HttpResponseMessage response,
			CancellationToken cancellationToken = default)
		{
			if (response.StatusCode == HttpStatusCode.OK)
			{
				var result =
					await response.Content
						.ReadFromJsonAsync<TResult>(
							JsonSerializerOptions,
							cancellationToken);

				return result;
			}
			else
			{
				var errorResult =
					await response.Content
						.ReadFromJsonAsync<FirecrawlErrorResult>(
							JsonSerializerOptions,
							cancellationToken);

				throw new FirecrawlException(
					response.StatusCode,
					errorResult?.Message);
			}
		}

		private readonly HttpClient httpClient;

		/// <summary>
		/// 
		/// </summary>
		public Uri BaseUrl =>
			this.httpClient
				.BaseAddress;

		/// <summary>
		/// 
		/// </summary>
		public AuthenticationHeaderValue AuthorizationHeaderValue =>
			this.httpClient
				.DefaultRequestHeaders
				.Authorization;

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
			ArgumentNullException
				.ThrowIfNull(
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
			ArgumentNullException
				.ThrowIfNull(
					options,
					nameof(options));

			if (!TryCreateScrapeUrl(
				out var requestUri))
			{
				throw new InvalidOperationException(
					$"Failed to create a valid URL for the request.");
			}

			var response =
				await this.httpClient
					.PostAsJsonAsync(
						requestUri,
						options,
						cancellationToken);

			return await ProcessResponseAsync<FirecrawlScrapeResult>(
				response,
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
			ArgumentNullException
				.ThrowIfNull(
					options,
					nameof(options));

			if (!TryCreateCrawlUrl(
				out var requestUri))
			{
				throw new InvalidOperationException(
					$"Failed to create a valid URL for the request.");
			}

			var response =
				await this.httpClient
					.PostAsJsonAsync(
						requestUri,
						options,
						cancellationToken);

			return await ProcessResponseAsync<FirecrawlCrawlResult>(
				response,
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
			ArgumentException
				.ThrowIfNullOrEmpty(
					id,
					nameof(id));

			if (!TryCreateCrawlResourceUrl(
				id,
				out var requestUri))
			{
				throw new InvalidOperationException(
					$"Failed to create a valid URL for the request.");
			}

			var response =
				await this.httpClient
					.GetAsync(
						requestUri,
						cancellationToken);

			return await ProcessResponseAsync<FirecrawlCrawlStatusResult>(
				response,
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
			ArgumentException
				.ThrowIfNullOrEmpty(
					id,
					nameof(id));

			if (!TryCreateCrawlResourceUrl(
				id,
				out var requestUri))
			{
				throw new InvalidOperationException(
					$"Failed to create a valid URL for the request.");
			}

			var response =
				await this.httpClient
					.DeleteAsync(
						requestUri,
						cancellationToken);

			return await ProcessResponseAsync<FirecrawlCrawlCancellationResult>(
				response,
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
			ArgumentNullException
				.ThrowIfNull(
					options,
					nameof(options));

			if (!TryCreateMapUrl(
				out var requestUri))
			{
				throw new InvalidOperationException(
					$"Failed to create a valid URL for the request.");
			}

			var response =
				await this.httpClient
					.PostAsJsonAsync(
						requestUri,
						options,
						cancellationToken);

			return await ProcessResponseAsync<FirecrawlMapResult>(
				response,
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
			ArgumentNullException
				.ThrowIfNull(
					options,
					nameof(options));

			if (!TryCreateBatchScrapeUrl(
				out var requestUri))
			{
				throw new InvalidOperationException(
					$"Failed to create a valid URL for the request.");
			}

			var response =
				await this.httpClient
					.PostAsJsonAsync(
						requestUri,
						options,
						cancellationToken);

			return await ProcessResponseAsync<FirecrawlBatchScrapeResult>(
				response,
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
			ArgumentException
				.ThrowIfNullOrEmpty(
					id,
					nameof(id));

			if (!TryCreateBatchScrapeResourceUrl(
				id,
				out var requestUri))
			{
				throw new InvalidOperationException(
					$"Failed to create a valid URL for the request.");
			}

			var response =
				await this.httpClient
					.GetAsync(
						requestUri,
						cancellationToken);

			return await ProcessResponseAsync<FirecrawlBatchScrapeStatusResult>(
				response,
				cancellationToken);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="result"></param>
		/// <returns></returns>
		private bool TryCreateScrapeUrl(
			out Uri result) =>
				Uri.TryCreate(
					BaseUrl,
					"scrape",
					out result);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="result"></param>
		/// <returns></returns>
		private bool TryCreateCrawlUrl(
			out Uri result) =>
				Uri.TryCreate(
					BaseUrl,
					"crawl",
					out result);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		private bool TryCreateCrawlResourceUrl(
			string id,
			out Uri result) =>
				Uri.TryCreate(
					BaseUrl,
					String.Format(
						CultureInfo.InvariantCulture,
						"crawl/{0}",
						id),
					out result);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="result"></param>
		/// <returns></returns>
		private bool TryCreateMapUrl(
			out Uri result) =>
				Uri.TryCreate(
					BaseUrl,
					"map",
					out result);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="result"></param>
		/// <returns></returns>
		private bool TryCreateBatchScrapeUrl(
			out Uri result) =>
				Uri.TryCreate(
					BaseUrl,
					"batch/scrape",
					out result);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="result"></param>
		/// <returns></returns>
		private bool TryCreateBatchScrapeResourceUrl(
			string id,
			out Uri result) =>
				Uri.TryCreate(
					BaseUrl,
					String.Format(
						CultureInfo.InvariantCulture,
						"batch/scrape/{0}",
						id),
					out result);
	}
}

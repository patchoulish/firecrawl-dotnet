using System;
using System.Threading;
using System.Threading.Tasks;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public interface IFirecrawlService
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlScrapeResult> ScrapeAsync(
			FirecrawlScrapeOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlCrawlResult> CrawlAsync(
			FirecrawlCrawlOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlCrawlStatusResult> GetCrawlStatusAsync(
			string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlCrawlCancellationResult> CancelCrawlAsync(
			string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlMapResult> MapAsync(
			FirecrawlMapOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlBatchScrapeResult> BatchScrapeAsync(
			FirecrawlBatchScrapeOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="id"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlBatchScrapeStatusResult> GetBatchScrapeStatusAsync(
			string id,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlSearchResult> SearchAsync(
			FirecrawlSearchOptions options,
			CancellationToken cancellationToken = default);

		/// <summary>
		/// 
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public Task<FirecrawlCreditUsageResult> GetCreditUsageAsync(
			CancellationToken cancellationToken = default);
	}
}

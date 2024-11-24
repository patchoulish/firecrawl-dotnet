using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

using Microsoft;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Firecrawl
{
	partial class FirecrawlServiceTests
	{
		/// <summary>
		/// 
		/// </summary>
		public static IEnumerable<object[]> ScrapeThrowOnBadRequestTestData =>
			[
				[
					new FirecrawlScrapeOptions()
					{
						Url = new Uri("https://www.reddit.com/"),
						Formats = new FirecrawlFormat[]
						{
							FirecrawlFormat.Markdown
						}.ToImmutableArray(),
					}
				],
			];

		/// <summary>
		/// 
		/// </summary>
		public static IEnumerable<object[]> ScrapeTestData =>
			[
				[
					new FirecrawlScrapeOptions()
					{
						Url = new Uri("https://en.wikipedia.org/wiki/Main_Page"),
						Formats = new FirecrawlFormat[]
						{
							FirecrawlFormat.Markdown
						}.ToImmutableArray(),
					}
				],
			];

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"Scrape")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task ScrapeThrowOnArgumentNullTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentNullException>(
				() => this.firecrawl.ScrapeAsync(
					default));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"Scrape")]
		[TestCategory(
			"BadRequest")]
		[DataTestMethod]
		[DynamicData(
			nameof(ScrapeThrowOnBadRequestTestData))]
		public async Task ScrapeThrowOnBadRequestAsync(
			FirecrawlScrapeOptions options)
		{
			await Assert.ThrowsExceptionAsync<FirecrawlException>(
				() => this.firecrawl.ScrapeAsync(
					options));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"Scrape")]
		[TestCategory(
			"Result")]
		[DataTestMethod]
		[DynamicData(
			nameof(ScrapeTestData))]
		public async Task ScrapeAsync(
			FirecrawlScrapeOptions options)
		{
			var scrapeResult =
				await this.firecrawl
					.ScrapeAsync(
						options);

			Assert.IsNotNull(
				scrapeResult);

			Assert.IsTrue(
				scrapeResult.Success);
		}
	}
}

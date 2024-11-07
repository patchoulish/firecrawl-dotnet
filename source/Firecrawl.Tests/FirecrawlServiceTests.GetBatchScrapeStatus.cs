using System;
using System.Threading;
using System.Threading.Tasks;

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
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"GetBatchScrapeStatus")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task GetBatchScrapeStatusThrowOnArgumentNullTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentNullException>(
				() => this.firecrawl.GetBatchScrapeStatusAsync(
					default));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"GetBatchScrapeStatus")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task GetBatchScrapeStatusThrowOnArgumentEmptyTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentException>(
				() => this.firecrawl.GetBatchScrapeStatusAsync(
					String.Empty));
		}
	}
}

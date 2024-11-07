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
			"GetCrawlStatus")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task GetCrawlStatusThrowOnArgumentNullTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentNullException>(
				() => this.firecrawl.GetCrawlStatusAsync(
					default));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"GetCrawlStatus")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task GetCrawlStatusThrowOnArgumentEmptyTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentException>(
				() => this.firecrawl.GetCrawlStatusAsync(
					String.Empty));
		}
	}
}

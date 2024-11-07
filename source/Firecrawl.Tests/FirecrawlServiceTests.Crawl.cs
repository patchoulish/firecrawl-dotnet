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
			"Crawl")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task CrawlThrowOnArgumentNullTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentNullException>(
				() => this.firecrawl.CrawlAsync(
					default));
		}
	}
}

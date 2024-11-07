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
			"CancelCrawl")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task CancelCrawlThrowOnArgumentNullTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentNullException>(
				() => this.firecrawl.CancelCrawlAsync(
					default));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"CancelCrawl")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task CancelCrawlThrowOnArgumentEmptyTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentException>(
				() => this.firecrawl.CancelCrawlAsync(
					String.Empty));
		}
	}
}

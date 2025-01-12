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
		/// <param name="options"></param>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"GetCreditUsage")]
		[TestCategory(
			"Result")]
		[TestMethod]
		public async Task GetCreditUsageAsync()
		{
			var creditUsageResult =
				await this.firecrawl
					.GetCreditUsageAsync();

			Assert.IsNotNull(
				creditUsageResult);

			Assert.IsTrue(
				creditUsageResult.Success);
		}
	}
}

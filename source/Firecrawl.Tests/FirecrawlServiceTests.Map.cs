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
			"Map")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task MapThrowOnArgumentNullTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentNullException>(
				() => this.firecrawl.MapAsync(
					default));
		}
	}
}

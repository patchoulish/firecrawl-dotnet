using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

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
		public static IEnumerable<object[]> MapThrowOnBadRequestTestData =>
			[
				[
					new FirecrawlMapOptions()
					{
						Url = new Uri("https://www.reddit.com/"),
					}
				],
			];

		/// <summary>
		/// 
		/// </summary>
		public static IEnumerable<object[]> MapTestData =>
			[
				[
					new FirecrawlMapOptions()
					{
						Url = new Uri("https://en.wikipedia.org/wiki/Main_Page"),
						Query = "Featured Article"
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="options"></param>
		/// <returns></returns>
		[TestCategory(
			"FirecrawlService")]
		[TestCategory(
			"Map")]
		[TestCategory(
			"BadRequest")]
		[DataTestMethod]
		[DynamicData(
			nameof(MapThrowOnBadRequestTestData))]
		public async Task MapThrowOnBadRequestAsync(
			FirecrawlMapOptions options)
		{
			await Assert.ThrowsExceptionAsync<FirecrawlException>(
				() => this.firecrawl.MapAsync(
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
			"Map")]
		[TestCategory(
			"Result")]
		[DataTestMethod]
		[DynamicData(
			nameof(MapTestData))]
		public async Task MapAsync(
			FirecrawlMapOptions options)
		{
			var mapResult =
				await this.firecrawl
					.MapAsync(
						options);

			Assert.IsNotNull(
				mapResult);

			Assert.IsTrue(
				mapResult.Success);
		}
	}
}

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
		public static IEnumerable<object[]> SearchThrowOnBadRequestTestData =>
			[
				[
					new FirecrawlSearchOptions()
					{
						Query = default
					}
				],
			];

		/// <summary>
		/// 
		/// </summary>
		public static IEnumerable<object[]> SearchTestData =>
			[
				[
					new FirecrawlSearchOptions()
					{
						Query = "current weather san francisco"
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
			"Search")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public async Task SearchThrowOnArgumentNullTestAsync()
		{
			await Assert.ThrowsExceptionAsync<ArgumentNullException>(
				() => this.firecrawl.SearchAsync(
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
			"Search")]
		[TestCategory(
			"BadRequest")]
		//[DataTestMethod]
		[DynamicData(
			nameof(SearchThrowOnBadRequestTestData))]
		public async Task SearchThrowOnBadRequestAsync(
			FirecrawlSearchOptions options)
		{
			await Assert.ThrowsExceptionAsync<FirecrawlException>(
				() => this.firecrawl.SearchAsync(
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
			"Search")]
		[TestCategory(
			"Result")]
		//[DataTestMethod]
		[DynamicData(
			nameof(SearchTestData))]
		public async Task SearchAsync(
			FirecrawlSearchOptions options)
		{
			var searchResult =
				await this.firecrawl
					.SearchAsync(
						options);

			Assert.IsNotNull(
				searchResult);

			Assert.IsTrue(
				searchResult.Success);
		}
	}
}

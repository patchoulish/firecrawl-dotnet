using System;

using Microsoft;
using Microsoft.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Firecrawl.Extensions.DependencyInjection
{
	/// <summary>
	/// 
	/// </summary>
	[TestClass]
	public sealed class ServiceCollectionExtensionsTests
	{
		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[TestCategory(
			"ServiceCollectionExtensions")]
		[TestCategory(
			"AddFirecrawlHttpClient")]
		[TestCategory(
			"Argument")]
		[TestMethod]
		public void AddFirecrawlHttpClientThrowOnArgumentNullTest()
		{
			Assert.ThrowsException<ArgumentNullException>(
				() => ServiceCollectionExtensions
					.AddFirecrawlHttpClient(
						default));
		}

		/// <summary>
		/// 
		/// </summary>
		/// <returns></returns>
		[TestCategory(
			"ServiceCollectionExtensions")]
		[TestCategory(
			"AddFirecrawlHttpClient")]
		[TestCategory(
			"Result")]
		[TestMethod]
		public void AddFirecrawlHttpClientPassTest()
		{
			var services =
				new ServiceCollection();

			services.AddFirecrawlHttpClient(
				(options) =>
				{
					options.ApiKey =
						Environment.GetEnvironmentVariable(
							"FIRECRAWL_API_KEY");
				});

			var serviceProvider =
				services.BuildServiceProvider();

			var firecrawl =
				serviceProvider.GetService<IFirecrawlService>();

			Assert.IsNotNull(
				firecrawl);
		}
	}
}

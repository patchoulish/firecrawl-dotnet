using System;

using Microsoft;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	[TestClass]
	public sealed partial class FirecrawlServiceTests
	{
		private FirecrawlService firecrawl;

		/// <summary>
		/// 
		/// </summary>
		[TestInitialize]
		public void Initialize()
		{
			this.firecrawl =
				new FirecrawlService(
					Environment.GetEnvironmentVariable(
						"FIRECRAWL_API_KEY"));
		}
	}
}

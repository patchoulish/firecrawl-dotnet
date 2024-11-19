using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Firecrawl
{
	/// <summary>
	/// Represents a <see cref="DelegatingHandler"/> that treats responses as
	/// having been sent by Firecrawl.
	/// </summary>
	public sealed class FirecrawlDelegatingHandler :
		DelegatingHandler
	{
		/// <summary>
		/// Creates a new instance of the
		/// <see cref="FirecrawlDelegatingHandler"/> class.
		/// </summary>
		public FirecrawlDelegatingHandler() :
			base()
		{ }

		/// <inheritdoc/>
		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			var httpClientResponse =
				default(HttpResponseMessage);

			try
			{
				httpClientResponse =
					await base.SendAsync(
						request,
						cancellationToken);
			}
			catch (Exception ex)
			{
				throw new FirecrawlException(
					"The operation was not successful.",
					ex);
			}

			if (httpClientResponse.StatusCode != HttpStatusCode.OK)
			{
				var error =
					await httpClientResponse.Content
						.ReadFromJsonAsync<FirecrawlError>(
							FirecrawlService.JsonSerializerOptions,
							cancellationToken);

				throw new FirecrawlException(
					"The operation was not successful.",
					default,
					httpClientResponse.StatusCode,
					error);
			}

			return httpClientResponse;
		}
	}
}

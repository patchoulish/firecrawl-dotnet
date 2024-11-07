using System;
using System.Net;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlException :
		Exception
	{
		/// <summary>
		/// 
		/// </summary>
		public HttpStatusCode? StatusCode { get; private init; }

		/// <summary>
		/// 
		/// </summary>
		public FirecrawlException() :
				this(
					default)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="statusCode"></param>
		public FirecrawlException(
			HttpStatusCode statusCode) :
				this(
					statusCode,
					default)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="statusCode"></param>
		/// <param name="message"></param>
		public FirecrawlException(
			HttpStatusCode statusCode,
			string message) :
				this(
					statusCode,
					message,
					default)
		{ }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="statusCode"></param>
		/// <param name="message"></param>
		/// <param name="innerException"></param>
		public FirecrawlException(
			HttpStatusCode statusCode,
			string message,
			Exception innerException) :
				base(
					message,
					innerException)
		{
			StatusCode = statusCode;
		}
	}
}

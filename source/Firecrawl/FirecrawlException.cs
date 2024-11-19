using System;
using System.Net;
using System.Net.Http;

namespace Firecrawl
{
	/// <summary>
	/// 
	/// </summary>
	public class FirecrawlException :
		HttpRequestException
	{
#if NETSTANDARD

		/// <summary>
		/// Gets the HTTP status code for this exception, if any.
		/// </summary>
		public HttpStatusCode? StatusCode { get; private init; }

#endif

		/// <summary>
		/// Gets the Firecrawl error for this exception, if any.
		/// </summary>
		public FirecrawlError Error { get; private init; }

		/// <summary>
		/// Initializes a new instance of the <see cref="FirecrawlException"/>
		/// class.
		/// </summary>
		public FirecrawlException() :
			this(
				default)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="FirecrawlException"/>
		/// class with a specific message that describes the current exception.
		/// </summary>
		/// <param name="message">
		/// A message that describes the current exception.
		/// </param>
		public FirecrawlException(
			string message) :
				this(
					message,
					default)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="FirecrawlException"/>
		/// class with a specific message that describes the current exception
		/// and an inner exception.
		/// </summary>
		/// <param name="message">
		/// A message that describes the current exception.
		/// </param>
		/// <param name="innerException">
		/// The inner exception.
		/// </param>
		public FirecrawlException(
			string message,
			Exception innerException) :
				this(
					message,
					innerException,
					default)
		{ }

		/// <summary>
		/// Initializes a new instance of the <see cref="FirecrawlException"/>
		/// class with a specific message that describes the current exception,
		/// an inner exception, and an HTTP status code.
		/// </summary>
		/// <param name="message">
		/// A message that describes the current exception.
		/// </param>
		/// <param name="innerException">
		/// The inner exception.
		/// </param>
		/// <param name="statusCode">
		/// The HTTP status code.
		/// </param>
		public FirecrawlException(
			string message,
			Exception innerException,
			HttpStatusCode? statusCode) :
				this(
					message,
					innerException,
					statusCode,
					default)
		{ }

#if NETSTANDARD

		/// <summary>
		/// Initializes a new instance of the <see cref="FirecrawlException"/>
		/// class with a specific message that describes the current exception,
		/// an inner exception, an HTTP status code, and Firecrawl error.
		/// </summary>
		/// <param name="message">
		/// A message that describes the current exception.
		/// </param>
		/// <param name="innerException">
		/// The inner exception.
		/// </param>
		/// <param name="statusCode">
		/// The HTTP status code.
		/// </param>
		/// <param name="error">
		/// The Firecrawl error.
		/// </param>
		public FirecrawlException(
			string message,
			Exception innerException,
			HttpStatusCode? statusCode,
			FirecrawlError error) :
				base(
					message,
					innerException)
		{
			StatusCode = statusCode;
			Error = error;
		}

#endif

#if NET

		/// <summary>
		/// Initializes a new instance of the <see cref="FirecrawlException"/>
		/// class with a specific message that describes the current exception,
		/// an inner exception, an HTTP status code, and Firecrawl error.
		/// </summary>
		/// <param name="message">
		/// A message that describes the current exception.
		/// </param>
		/// <param name="innerException">
		/// The inner exception.
		/// </param>
		/// <param name="statusCode">
		/// The HTTP status code.
		/// </param>
		/// <param name="error">
		/// The Firecrawl error.
		/// </param>
		public FirecrawlException(
			string message,
			Exception innerException,
			HttpStatusCode? statusCode,
			FirecrawlError error) :
				base(
					message,
					innerException,
					statusCode)
		{
			Error = error;
		}

#endif
	}
}

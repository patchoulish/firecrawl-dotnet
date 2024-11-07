# firecrawl-dotnet [![CI](https://github.com/patchoulish/firecrawl-dotnet/actions/workflows/ci.yml/badge.svg)](https://github.com/patchoulish/firecrawl-dotnet/actions/workflows/ci.yml)
A .NET library for interacting with the [Firecrawl](https://www.firecrawl.dev/) API.


## Installation
Install the library via [NuGet](https://www.nuget.org/packages/firecrawl-dotnet):
```bash
dotnet add package firecrawl-dotnet
```

### Extensions
Install optional library extensions for more functionality, depending on your use case.
#### Dependency Injection
Integrate firecrawl-dotnet and your DI container of choice. Install the extension library via [NuGet](https://www.nuget.org/packages/firecrawl-dotnet-dependencyinjection):
```bash
dotnet add package firecrawl-dotnet-dependencyinjection
```


## Usage
1. Obtain an API key from the [Firecrawl Dashboard](https://www.firecrawl.dev/app) (requires a Firecrawl account).
2. Pass the API key into a new instance of the `FirecrawlService` class or use a configured `HttpClient` if advanced configuration (e.g., proxies) is required.
3. Use the methods available on `FirecrawlService` to interact with the Firecrawl API.

### Initialization
The library can be initialized in three ways:
#### Basic Initialization
Pass in your API key directly:
```csharp
var firecrawl = new FirecrawlService("YOUR_FIRECRAWL_API_KEY");
```
#### Advanced Initialization
Use an existing `HttpClient`, ensuring that `BaseAddress` and an `Authorization` header have been set:
```csharp
var httpClient = new HttpClient
{
    BaseAddress = new Uri("https://api.firecrawl.dev/v1/"),
    Timeout = TimeSpan.FromSeconds(5)
};

httpClient.DefaultRequestHeaders.Authorization =
	new AuthenticationHeaderValue("Bearer", "YOUR_FIRECRAWL_API_KEY");

var firecrawl = new FirecrawlService(httpClient);
```
#### Dependency Injection
If you've installed the appropriate extension library.
1. Register `FirecrawlService` with your dependency container:
```csharp
services.AddFirecrawlHttpClient(options =>
{
	options.BaseUrl = new Uri("https://api.firecrawl.dev/v1/");
	options.ApiKey = "YOUR_FIRECRAWL_API_KEY";
});
```
2. Inject `IFirecrawlService` where needed:
```csharp
public class MyClass
{
    private readonly IFirecrawlService firecrawl;

    public MyClass(IFirecrawlService firecrawl)
    {
        this.firecrawl = firecrawl;
    }
}
```


## Documentation
Refer to the [Usage](#usage) section above for a quick start, or consult the inline documentation while working in your IDE. For detailed information about the underlying API endpoints, parameters, and expected responses, refer to the [official Firecrawl API documentation](https://docs.firecrawl.dev/api-reference/introduction).


## Contributing
Contributions are welcome! To contribute, fork the repository, create a new branch, and submit a pull request with your changes. Please make sure all tests pass before submitting.


## License
This project is licensed under the MIT license. See `license.txt` for full details.

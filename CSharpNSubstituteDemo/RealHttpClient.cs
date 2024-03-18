namespace CSharpNSubstituteDemo;

class RealHttpClient : IHttpClient
{
    private readonly HttpClient _httpClient = new HttpClient();

    public Task<string> GetAsync(string uri)
    {
        return _httpClient.GetStringAsync(uri);
    }
}

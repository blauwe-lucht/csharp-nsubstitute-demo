namespace CSharpNSubstituteDemo;

public interface IHttpClient
{
    Task<string> GetAsync(string uri);
}

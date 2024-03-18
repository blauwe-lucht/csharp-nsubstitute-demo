using System.Text.Json;

namespace CSharpNSubstituteDemo;

public class StarWarsApi
{
    private readonly IHttpClient _httpClient;

    public StarWarsApi(IHttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<StarWarsPerson> GetPersonData(int id)
    {
        string uri = $"https://swapi.dev/api/people/{id}/";
        string body = await _httpClient.GetAsync(uri);
        if (string.IsNullOrEmpty(body))
        {
            throw new Exception("body is empty");
        }

        StarWarsPerson? person = JsonSerializer.Deserialize<StarWarsPerson>(body);
        if (person == null)
        {
            throw new InvalidDataException($"Could not parse {body}");
        }

        return person;
    }
}

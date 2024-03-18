
namespace CSharpNSubstituteDemo;

internal class Program
{
    private static async Task Main(string[] args)
    {
        int peopleId = 1;
        if (args.Length > 0)
        {
            peopleId = int.Parse(args[0]);
        }

        var api = new StarWarsApi(new RealHttpClient());
        StarWarsPerson person = await api.GetPersonData(peopleId);
        Console.WriteLine(person);
    }
}

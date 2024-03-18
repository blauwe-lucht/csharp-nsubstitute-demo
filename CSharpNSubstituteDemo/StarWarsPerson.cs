using System.Text;
using System.Text.Json.Serialization;

namespace CSharpNSubstituteDemo;

public class StarWarsPerson
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("birth_year")]
    public string BirthYear { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    public StarWarsPerson(string name, string birthYear, string gender)
    {
        Name = name;
        BirthYear = birthYear;
        Gender = gender;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"Name: {Name}");
        sb.AppendLine($"Birth year: {BirthYear}");
        sb.AppendLine($"Gender: {Gender}");
        return sb.ToString();
    }
}

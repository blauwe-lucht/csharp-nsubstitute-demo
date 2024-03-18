using NSubstitute;

namespace CSharpNSubstituteDemoTests;

public class StarWarsApiTests
{
    [Test]
    public async Task GetPersonData_ShouldReturnCorrectData()
    {
        // Arrange
        var httpClient = Substitute.For<IHttpClient>();
        var mockJson = "{\"name\":\"Luke Skywalker\",\"birth_year\":\"19BBY\",\"gender\":\"male\"}";
        httpClient.GetAsync(Arg.Any<string>()).Returns(Task.FromResult(mockJson));

        var sut = new StarWarsApi(httpClient);

        // Act
        var person = await sut.GetPersonData(1);

        // Assert
        Assert.That(person.Name, Is.EqualTo("Luke Skywalker"));
        Assert.That(person.BirthYear, Is.EqualTo("19BBY"));
        Assert.That(person.Gender, Is.EqualTo("male"));
    }
}

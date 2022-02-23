using BlazorMediatorDemo.Shared.Models;

namespace BlazorMediatorDemo.Shared.Services;

public class PersonService : IPersonService
{
    private List<Person> _people = new();

    public PersonService()
    {
        _people.Add(new() { Id = 1, FirstName = "German", LastName = "De Francesco" });
        _people.Add(new() { Id = 2, FirstName = "Tim", LastName = "Corey" });
    }

    public List<Person> GetPeople()
    {
        return _people;
    }

    public Person? GetPerson(int id)
    {
        return _people.FirstOrDefault(x => x.Id == id);
    }

    public Person InsertPerson(string firstName, string lastName)
    {
        var person = new Person() { FirstName = firstName, LastName = lastName };
        person.Id = _people.Max(x => x.Id) + 1;
        _people.Add(person);
        return person;
    }
}

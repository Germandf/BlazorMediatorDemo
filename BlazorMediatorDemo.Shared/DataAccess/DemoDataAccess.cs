using BlazorMediatorDemo.Shared.Models;

namespace BlazorMediatorDemo.Shared.DataAccess;

public class DemoDataAccess : IDataAccess
{
    private List<PersonModel> _people = new();

    public DemoDataAccess()
    {
        _people.Add(new() { Id = 1, FirstName = "German", LastName = "De Francesco" });
        _people.Add(new() { Id = 2, FirstName = "Tim", LastName = "Corey" });
    }

    public List<PersonModel> GetPeople()
    {
        return _people;
    }

    public PersonModel? GetPerson(int id)
    {
        return _people.FirstOrDefault(x => x.Id == id);
    }

    public PersonModel InsertPerson(string firstName, string lastName)
    {
        var person = new PersonModel() { FirstName = firstName, LastName = lastName };
        person.Id = _people.Max(x => x.Id) + 1;
        _people.Add(person);
        return person;
    }
}

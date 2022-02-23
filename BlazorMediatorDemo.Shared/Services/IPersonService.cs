using BlazorMediatorDemo.Shared.Models;

namespace BlazorMediatorDemo.Shared.Services;

public interface IPersonService
{
    List<Person> GetPeople();
    Person? GetPerson(int id);
    Person InsertPerson(string firstName, string lastName);
}

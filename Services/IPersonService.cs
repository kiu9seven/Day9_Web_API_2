using Day9.Models;

namespace Day9.Services;

public interface IPersonService
{
    List<Person> GetAll();
    Person GetOne(int index);
    
    Person Create(Person person);
    Person Update(int Index, Person person);
    void Delete(int index);

}
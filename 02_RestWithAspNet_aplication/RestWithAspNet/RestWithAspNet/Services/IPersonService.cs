using RestWithAspNet.Model;
using System.Collections.Generic;

namespace RestWithAspNet.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindBayID(long id);
        List<Person> FindAll();
        Person Updade(Person person);
        void Delete(long id);
    }
}

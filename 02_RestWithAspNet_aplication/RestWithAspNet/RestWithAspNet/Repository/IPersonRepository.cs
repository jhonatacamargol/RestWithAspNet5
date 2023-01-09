using RestWithAspNet.Model;
using System.Collections.Generic;

namespace RestWithAspNet.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindBayID(long id);
        List<Person> FindAll();
        Person Updade(Person person);
        void Delete(long id);

        bool Exists(long id);
    }
}

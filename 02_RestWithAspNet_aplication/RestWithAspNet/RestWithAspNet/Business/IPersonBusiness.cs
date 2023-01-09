using RestWithAspNet.Model;
using System.Collections.Generic;

namespace RestWithAspNet.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindBayID(long id);
        List<Person> FindAll();
        Person Updade(Person person);
        void Delete(long id);
    }
}

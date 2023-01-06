using RestWithAspNet.Model;
using RestWithAspNet.Model.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace RestWithAspNet.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySqlContext _Context;

        public PersonServiceImplementation(MySqlContext context) 
        { 
            _Context= context;
        }

        public Person Create(Person person)
        {
            _Context.Add(person);
            _Context.SaveChanges();

            return person;
        }

        public void Delete(long id)
        {
            var person = _Context.Persons.FirstOrDefault(x => x.Id == id);
            _Context.Remove(person);
            _Context.SaveChanges();
        }

        public List<Person> FindAll()
        {
             return _Context.Persons.ToList();
        }

     

        public Person FindBayID(long id)
        {
            return _Context.Persons.FirstOrDefault(x => x.Id == id);
        }

        public Person Updade(Person person)
        {
            return person;
        }

    }
}

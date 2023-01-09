using RestWithAspNet.Model;
using RestWithAspNet.Model.Context;
using RestWithAspNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithAspNet.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IPersonRepository _repository;

        public PersonBusinessImplementation(IPersonRepository repository) 
        { 
            _repository = repository;
        }

        
        public List<Person> FindAll()
        {
             return _repository.FindAll();
        }
        public Person FindBayID(long id)
        {
            return _repository.FindBayID(id);
        }
        public Person Create(Person person)
        {
            return _repository.Create(person);
        }
        public Person Updade(Person person)
        {
            return _repository.Updade(person);
        }
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}

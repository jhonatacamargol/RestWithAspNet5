﻿using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RestWithAspNet.Model;
using RestWithAspNet.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestWithAspNet.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private MySqlContext _Context;

        public PersonServiceImplementation(MySqlContext context) 
        { 
            _Context = context;
        }

        
        public List<Person> FindAll()
        {
             return _Context.Persons.ToList();
        }
        public Person FindBayID(long id)
        {
            return _Context.Persons.FirstOrDefault(p => p.Id.Equals(id));
        }
        public Person Create(Person person)
        {
            try
            {
                _Context.Add(person);
                _Context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return person;
        }
        public Person Updade(Person person)
        {
            if (!Exists(person.Id)) return new Person();
           
            var result = _Context.Persons.FirstOrDefault(p => p.Id.Equals(person.Id));
            if (result != null)
            {
                try
                {
                    _Context.Entry(result).CurrentValues.SetValues(person);
                    _Context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return person;
        }
        public void Delete(long id)
        {
            var result = _Context.Persons.FirstOrDefault(p => p.Id.Equals(id));
            if (result != null) 
            {
                try
                {
                    _Context.Persons.Remove(result);
                    _Context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            } 
        }
        private bool Exists(long id)
        {
            return _Context.Persons.Any(p=> p.Id.Equals(id));
        }
    }
}
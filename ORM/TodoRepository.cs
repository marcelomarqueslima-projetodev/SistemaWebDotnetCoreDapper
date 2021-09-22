using Entities;
using Microsoft.Extensions.Configuration;
using ORM.Interfaces;
using System.Collections.Generic;

namespace ORM
{
    public class TodoRepository : RepositoryConnector, ITodoRepository
    {
        public TodoRepository(IConfiguration config) : base(config) { }
        public void Add(Todo obj)
        {
            throw new System.NotImplementedException();
        }

        public Todo Get(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Todo> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Todo obj)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Todo obj)
        {
            throw new System.NotImplementedException();
        }
    }
}

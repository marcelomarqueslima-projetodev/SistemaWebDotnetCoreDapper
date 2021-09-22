using Dapper;
using Entities;
using Microsoft.Extensions.Configuration;
using ORM.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ORM
{
    public class TodoRepository : RepositoryConnector, ITodoRepository
    {
        public TodoRepository(IConfiguration config) : base(config) { }
        public void Add(Todo obj)
        {
            DynamicParameters pam = new DynamicParameters();
            pam.Add("@Tarefa", obj.Tarefa);

            string sql = "INSERT INTO Todo (Tarefa) VALUES (@Tarefa)";

            using (var con = new SqlConnection(base.GetConnection()))
            {
                con.Execute(sql, pam);
            }
        }

        public Todo Get(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Todo> GetAll()
        {
            IEnumerable<Todo> retorno;
            string sql = "SELECT * FROM Todo";
            using (var con = new SqlConnection(GetConnection()))
            {
                retorno = con.Query<Todo>(sql);
            }
            return retorno;
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

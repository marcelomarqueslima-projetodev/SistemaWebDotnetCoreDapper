using Dapper;
using Entities;
using Microsoft.Extensions.Configuration;
using ORM.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

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
            string sql = $"SELECT * FROM Todo WHERE Id = {Id}";

            using(var con = new SqlConnection(base.GetConnection()))
            {
                return con.Query<Todo>(sql).FirstOrDefault();
            }
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
            string sql = $"DELETE FROM Todo WHERE Id = {obj.Id}";
            using (var con = new SqlConnection(GetConnection()))
            {
                con.Execute(sql);
            }
        }

        public void Update(Todo obj)
        {
            string sql = $@"UPDATE Todo SET Tarefa = @Tarefa WHERE Id = {obj.Id}";

            DynamicParameters pam = new DynamicParameters();
            pam.Add("@Tarefa", obj.Tarefa);

            using (var con = new SqlConnection(GetConnection()))
            {
                con.Execute(sql, pam);
            }
        }
    }
}

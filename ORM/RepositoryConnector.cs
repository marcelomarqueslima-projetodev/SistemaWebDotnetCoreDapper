using Microsoft.Extensions.Configuration;

namespace ORM
{
    public class RepositoryConnector
    {
        public IConfiguration _configuration;

        public RepositoryConnector(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetConnection()
        {
            return _configuration.GetSection("Connection").GetSection("ConnectionString").Value;
        }
    }
}

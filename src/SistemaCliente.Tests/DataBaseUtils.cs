using WebMatrix.Data;

namespace SistemaCliente.Tests
{
    public class DataBaseService
    {
        private readonly string _connectionString;
        private readonly string _providerName;

        public DataBaseService(string connetionString, string providerName)
        {
            _providerName = providerName;
            _connectionString = connetionString;
        }

        public void RemoveTabelaCliente()
        {
            var db = Database.OpenConnectionString(_connectionString, _providerName);
            var query = string.Format("Delete From Cliente");

            db.Execute(query);
        }
    }
}

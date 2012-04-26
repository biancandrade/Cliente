using System;
using System.Collections.Generic;
using System.Linq;
using SistemaCliente.DI;
using WebMatrix.Data;

namespace SistemaCliente.Infra
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly string _connectionString;
        private readonly string _providerName;

        public ClienteRepositorio(string connectionString, string providerName)
        {
            _connectionString = connectionString;
            _providerName = providerName;
        }

        public Cliente Inserir(Cliente cliente)
        {
            var  db= ObterBancoDados();

            var query = "Insert Into Cliente (Id, Nome, DataCadastro) values (@0,@1,@2)";

            db.Execute(query, cliente.Id, cliente.Nome, cliente.DataCadastro);

            var id = db.QuerySingle("Select @@IDENTITY as LastIdentity").LastIdentity;

            cliente.Id = Convert.ToInt32(id);

            return cliente;
        }

    

        private Database ObterBancoDados()
        {
            return Database.OpenConnectionString(_connectionString, _providerName);
        }


        public List<Cliente> ObterTodos()
        {
            var db = ObterBancoDados();
            var query = "Select Codigo,Nome,DataCadastro From Cliente";
            var clientes = new List<Cliente>();

            foreach (var linha in db.Query(query))
            {
                var cliente = new Cliente();

                cliente.Id = linha.Codigo;
                cliente.Nome = linha.Nome;
                cliente.DataCadastro = linha.DataCadastro;

                clientes.Add(cliente);
            }

            return clientes;
        }

        public Cliente ObterPor(int id)
        {
            var db = ObterBancoDados();
            var query = "Select Codigo,Nome,DataCadastro From Cliente Where Codigo = @0";
            var queryResult = db.Query(query, id);

            return ConveterParaCliente(queryResult).FirstOrDefault();
        }
   

        private static List<Cliente> ConveterParaCliente(IEnumerable<dynamic> queryResult)
        {
            var clientes = new List<Cliente>();

            foreach (var linha in queryResult)
            {
                var cliente = new Cliente();

                cliente.Id = linha.Codigo;
                cliente.Nome = linha.Nome;
                cliente.DataCadastro = linha.DataCadastro;

                clientes.Add(cliente);
            }
            return clientes;
        }

    
    }
}

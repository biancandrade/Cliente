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

            var query = "Insert Into Cliente (Nome, DataCadastro) values (@0,@1)";

            db.Execute(query, cliente.Nome, cliente.DataCadastro);

            var id = db.QuerySingle("Select @@Identity as LastIdentity ").LastIdentity;

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
            const string query = "Select Id,Nome,DataCadastro From Cliente";
            var clientes = new List<Cliente>();

            foreach (var linha in db.Query(query))
            {
                var cliente = new Cliente();
                
                cliente.Id = linha.Id;
                cliente.Nome = linha.Nome;
                cliente.DataCadastro = linha.DataCadastro;

                clientes.Add(cliente);
            }

            return clientes;
        }

        public Cliente ObterPor(int id)
        {
            var db = ObterBancoDados();
            const string query = "Select Id,Nome,DataCadastro From Cliente Where Id = @0";
            var queryResult = db.Query(query, id);

            return ConverterParaCliente(queryResult).FirstOrDefault();
        }
   

        private static List<Cliente> ConverterParaCliente(IEnumerable<dynamic> queryResult)
        {
            var clientes = new List<Cliente>();

            foreach (var linha in queryResult)
            {
                var cliente = new Cliente();

                cliente.Id = linha.Id;
                cliente.Nome = linha.Nome;
                cliente.DataCadastro = linha.DataCadastro;

                clientes.Add(cliente);
            }
            return clientes;
        }

        public List<Cliente> ObterPesquisa(string nome)
        {
            var db = ObterBancoDados();
            const string query = "Select Id, Nome, DataCadastro from cliente where Nome = @0";
            var queryResult = db.Query(query, nome);

            return ConverterParaCliente(queryResult);
        }

        public void Excluir(Cliente cliente)
        {
            var db = ObterBancoDados();

            const string query = "DELETE Cliente FROM Cliente where Id = @0";

            db.Execute(query, cliente.Id);
        }
    }
}

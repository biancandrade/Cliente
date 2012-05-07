using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaCliente.DI;
using WebMatrix.Data;

namespace SistemaCliente.Infra
{
    public class EnderecoRepositorio: IEnderecoRepositorio
    {
         private readonly string _connectionString;
        private readonly string _providerName;

        public EnderecoRepositorio(string connectionString, string providerName)
        {
            _connectionString = connectionString;
            _providerName = providerName;
        }

        public Endereco Inserir(Endereco endereco)
        {
            var  db= ObterBancoDados();

            const string query = "Insert Into Endereco (Tipo, Nome, Bairro, Cidade, ClienteId) values (@0,@1,@2,@3,@4)";

            db.Execute(query, endereco.Tipo, endereco.Nome, endereco.Bairro, endereco.Cidade, endereco.ClienteId);

            var id = db.QuerySingle("Select @@IDENTITY as LastIdentity").LastIdentity;

            endereco.Id = Convert.ToInt32(id);

            return endereco;
        }

        public List<Endereco> ObterTodos()
        {
            var db = ObterBancoDados();
            const string query = "Select e.Id, e.ClienteId, e.Tipo, e.Nome, e.Bairro, e.Cidade From Endereco e, Cliente where e.ClienteId = Cliente.Id ";

            var enderecos = new List<Endereco>();

            foreach (var linha in db.Query(query))
            {
                var endereco = new Endereco();

                endereco.Id = linha.Id;
                endereco.ClienteId = linha.ClienteId;
                endereco.Nome = linha.Nome;
                endereco.Tipo = linha.Tipo;
                endereco.Bairro = linha.Bairro;
                endereco.Cidade = linha.Cidade;

                enderecos.Add(endereco);
            }
            return enderecos;
        }

        public List<Endereco> ObterPor(int id)
        {
            var db = ObterBancoDados();
            const string query = "Select e.Id, e.ClienteId, e.Tipo, e.Nome, e.Bairro, e.Cidade From Endereco e where e.ClienteId = @0";
            var queryResult = db.Query(query, id);

            return ConverterParaEndereco(queryResult);
        }

        public void Excluir(Endereco endereco)
        {
            var db = ObterBancoDados();

            const string query = "DELETE endereco from Endereco Where Id = @0";

            db.Execute(query, endereco.Id);
        }

        private static List<Endereco> ConverterParaEndereco(IEnumerable<dynamic> queryResult)
        {
            var enderecos = new List<Endereco>();

            foreach (var linha in queryResult)
            {
                var endereco = new Endereco();

                endereco.Id = linha.Id;
                endereco.ClienteId = linha.ClienteId;
                endereco.Tipo = linha.Tipo;
                endereco.Nome = linha.Nome;
                endereco.Bairro = linha.Bairro;
                endereco.Cidade = linha.Cidade;

                enderecos.Add(endereco);
            }
            return enderecos;
        }


        private Database ObterBancoDados()
        {
            return Database.OpenConnectionString(_connectionString, _providerName);
        }
    }
}

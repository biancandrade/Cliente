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

            var query = "Insert Into Endereco (Id, Tipo, Nome, Bairro, Cidade, ClienteId) values (@0,@1,@2,@3,@4,@5)";

            db.Execute(query, endereco.Id, endereco.Tipo, endereco.Nome, endereco.Bairro, endereco.Cidade, endereco.ClienteId);

            var id = db.QuerySingle("Select @@IDENTITY as LastIdentity").LastIdentity;

            endereco.Id = Convert.ToInt32(id);

            return endereco;
        }

    

        private Database ObterBancoDados()
        {
            return Database.OpenConnectionString(_connectionString, _providerName);
        }
    }
}

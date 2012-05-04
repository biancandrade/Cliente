using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCliente.DI
{
    public interface IClienteRepositorio
    {
        Cliente Inserir(Cliente cliente);

        List<Cliente> ObterTodos();

        Cliente ObterPor(int id);

        List<Cliente> ObterPesquisa(string nome);

        void Excluir(Cliente cliente);
    }
}

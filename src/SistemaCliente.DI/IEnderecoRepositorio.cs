using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaCliente.DI
{
    public interface IEnderecoRepositorio
    {
        Endereco Inserir(Endereco endereco);

        List<Endereco> ObterTodos();

        List<Endereco> ObterPor(int id);

        void Excluir(Endereco endereco);
    }
}

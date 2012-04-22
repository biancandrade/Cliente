using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaCliente.DI;

namespace SistemaCliente.Tests
{
    public class TodosClientesTestMock : ITodosClientes
    {
        readonly List<Cliente> _clientes = new List<Cliente>();

        public Cliente Inserir(Cliente cliente)
        {
            //cliente.Codigo == 0 ? 1 : clientes.Max(c => c.Codigo) 
            cliente.Codigo = _clientes.Count + 1;

            _clientes.Add(cliente);
            return cliente;
        }

        public List<Cliente> ObterTodos()
        {
            return _clientes;
        }


        public Cliente ObterPor(int id)
        {
            //FirstOrDefault 
            //foreach (var cliente in clientes)
            //{
            //    if (cliente.Codigo == id)
            //        return cliente;
            //}

            //return null;

            return _clientes.FirstOrDefault(cliente => cliente.Codigo == id);
        }
    }
}

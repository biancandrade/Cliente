﻿using System;
using System.Collections.Generic;

namespace SistemaCliente.DI
{
    public class ClienteServico
    {
        private readonly ITodosClientes _todosClientes;

        public ClienteServico(ITodosClientes todosClientes)
        {
            _todosClientes = todosClientes;
        }

        public void Salvar(Cliente cliente)
        {
            cliente.DataCadastro = DateTime.Now;

            cliente.VerificarSeDataEhNula();
            cliente.VerificarSeNomeEhVazio();

            _todosClientes.Inserir(cliente);
        }

        public List<Cliente> ObterTodos()
        {
            return _todosClientes.ObterTodos();
        }

        public Cliente ObterPor(int id)
        {
            var cliente = _todosClientes.ObterPor(id);

            return cliente;
        }
    }
}

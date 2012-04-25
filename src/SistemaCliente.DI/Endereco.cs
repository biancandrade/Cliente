using System;

namespace SistemaCliente.DI
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public Cliente ClienteId { get; set; }

        public void CheckSeTipoTemValor()
        {
            if (string.IsNullOrWhiteSpace(Tipo))
                throw new Exception("O tipo de endereço não pode ser vazio");
        }
    }
}

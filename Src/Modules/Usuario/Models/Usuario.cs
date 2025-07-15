using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Models
{
    internal class Usuario
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }

        public required Credenciais Credenciais { get; set; }

        public Usuario(Guid id, string nome, Credenciais credenciais)
        {
            Id = id;
            Nome = nome;
            Credenciais = credenciais;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Models
{
    internal class Credenciais
    {
        public Guid Id { get; set; }
        public required Guid UsuarioId {  get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }

        public Credenciais(Guid id, Guid usuarioId, string email, string senha)
        {
            Id = id;
            UsuarioId = usuarioId;
            Email = email;
            Senha = senha;
        }
    }
}

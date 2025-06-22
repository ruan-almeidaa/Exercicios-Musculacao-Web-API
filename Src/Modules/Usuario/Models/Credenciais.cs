using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario.Models
{
    public class Credenciais
    {
        public Guid Id { get; set; }
        public required Guid UsuarioId {  get; set; }
        public required string Email { get; set; }
        public required string Senha { get; set; }
    }
}

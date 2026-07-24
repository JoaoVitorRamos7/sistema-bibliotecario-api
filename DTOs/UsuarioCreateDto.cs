using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bibliotecario_api.DTOs
{
    public class UsuarioCreateDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
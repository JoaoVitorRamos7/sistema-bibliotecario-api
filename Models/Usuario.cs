using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_blibiotecario_api.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
        public ICollection<Emprestimo> Emprestimos { get; set; }
        
    }
}
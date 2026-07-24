using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bibliotecario_api.Models
{
    public class Emprestimo
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Usuario")]
        public int Usuario_id { get; set; }
        public Usuario usuario { get; set; }
        [ForeignKey("Livro")]
        public int Livro_id { get; set; }
        public Livro Livro { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucaoPresvista { get; set; }
        public DateTime DataDevolucaoReal { get; set; }
        public bool Devolvido { get; set; }
    }
}
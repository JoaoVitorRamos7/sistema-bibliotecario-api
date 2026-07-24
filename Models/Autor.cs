using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bibliotecario_api.Models
{
    public class Autor
    {
        [Key()]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Livro> Livros { get; set; }
    }
}
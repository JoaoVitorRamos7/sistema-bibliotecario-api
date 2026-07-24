using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bibliotecario_api.Models
{

    public class Livro
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int AnoPublicado { get; set; }
        [ForeignKey("Autor")]
        public int Autor_id { get; set; }
        public Autor Autor { get; set; }


    }
}
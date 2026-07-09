using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_blibiotecario_api.DTOs
{
    public class LivroCreateDto
    {
    
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public int AnoPublicado { get; set; }
        public int Autor_id { get; set; }


    }
}
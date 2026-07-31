using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistema_bibliotecario_api.DTOs
{
    public class AutorResponseDto
    {
        public int id { get; set; }
        public string nome { get; set; }
        public List<string> Livros { get; set; }
    }
}
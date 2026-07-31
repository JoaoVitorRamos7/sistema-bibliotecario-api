using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistema_bibliotecario_api.DTOs;
using sistema_bibliotecario_api.Models;

namespace sistema_bibliotecario_api.Repositories
{
    public interface ILivroRepository
    {
        void AddLivros(LivroCreateDto livro);
        List<Livro> GetLivros();
        Livro GetLivro(int id);
        bool Update(int id, [FromBody] LivroCreateDto livro);

        bool Delete(int id);
    }
}
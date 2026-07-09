using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistema_blibiotecario_api.DTOs;
using sistema_blibiotecario_api.Models;

namespace sistema_blibiotecario_api.Repositories
{
    public interface ILivroRepository
    {
        void AddLivros(LivroCreateDto livro);
        List<Livro> GetLivros();
        Livro GetLivro(int id); 
        bool Update(int id, [FromBody] LivroCreateDto livro);

        void Delete(int id);
    }
}
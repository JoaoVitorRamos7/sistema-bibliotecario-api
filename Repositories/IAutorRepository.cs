using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_blibiotecario_api.DTOs;
using sistema_blibiotecario_api.Models;

namespace sistema_blibiotecario_api.Repositories
{
    public interface IAutorRepository
    {
        void AddAutor(AutorCreateDto autor);
        List<Autor> GetAutores();
        Autor GetAutor(int id);
        bool Update(int id, AutorCreateDto autor);
        void Delete(int id);


    }
}
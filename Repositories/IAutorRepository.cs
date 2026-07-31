using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_bibliotecario_api.DTOs;
using sistema_bibliotecario_api.Models;

namespace sistema_bibliotecario_api.Repositories
{
    public interface IAutorRepository
    {
        void AddAutor(AutorCreateDto autor);
        List<AutorResponseDto> GetAutores();
        Autor GetAutor(int id);
        bool Update(int id, AutorCreateDto autor);
        bool Delete(int id);


    }
}
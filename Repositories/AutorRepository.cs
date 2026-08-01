using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sistema_bibliotecario_api.Data;
using sistema_bibliotecario_api.DTOs;
using sistema_bibliotecario_api.Models;

namespace sistema_bibliotecario_api.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly AppDbContext _appDbcontext;
        public AutorRepository(AppDbContext appDbcontext)
        {
            _appDbcontext = appDbcontext;
        }
        public void AddAutor(AutorCreateDto autor)
        {
            var AutorExiste = _appDbcontext.Autores.Any(a => a.Nome == autor.Nome);
            if (AutorExiste)
            {
                throw new InvalidOperationException("Já existe um autor com esse nome.");
            }

            var Autor = new Autor
            {
                Nome = autor.Nome
            };
            _appDbcontext.Autores.Add(Autor);
            _appDbcontext.SaveChanges();
        }

        public List<AutorResponseDto> GetAutores()
        {
            return _appDbcontext.Autores
                .Include(a => a.Livros)
                .Select(a => new AutorResponseDto
                {
                    id = a.Id,
                    nome = a.Nome,
                    Livros = a.Livros
                    .Select(l => l.Titulo)
                    .ToList()

                }).ToList();
        }

        public bool Update(int id, AutorCreateDto autor)
        {
            var AutorExistente = _appDbcontext.Autores.Find(id);
            if (AutorExistente == null)
            {
                return false;
            }
            AutorExistente.Nome = autor.Nome;
            _appDbcontext.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var Autor = _appDbcontext.Autores.Find(id);

            if (Autor == null)
            {
                return false;
            }
            _appDbcontext.Autores.Remove(Autor);
            _appDbcontext.SaveChanges();

            return true;
        }

        public Autor GetAutor(int id)
        {
            var Usuario = _appDbcontext.Autores.Find(id);
            if (Usuario == null)
            {

            }
            return Usuario;
        }
    }
}
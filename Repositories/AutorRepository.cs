using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var Autor = new Autor
            {
                Nome = autor.Nome
            };
            _appDbcontext.Autores.Add(Autor);
            _appDbcontext.SaveChanges();
        }

        public List<Autor> GetAutores()
        {
            var Autores = _appDbcontext.Autores.ToList();
            return Autores;
        }

        public bool Update(int id, AutorCreateDto autor)
        {
            var AutorExistente = _appDbcontext.Autores.Find(id);
            if (autor == null)
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
            return Usuario;
        }
    }
}
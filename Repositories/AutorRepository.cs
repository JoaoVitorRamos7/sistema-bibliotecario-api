using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_blibiotecario_api.Data;
using sistema_blibiotecario_api.DTOs;
using sistema_blibiotecario_api.Models;

namespace sistema_blibiotecario_api.Repositories
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

        public void Delete(int id)
        {
            var Autor = _appDbcontext.Autores.Find(id);
            _appDbcontext.Autores.Remove(Autor);
            _appDbcontext.SaveChanges();
        }

        public Autor GetAutor(int id)
        {
            var Usuario = _appDbcontext.Autores.Find(id);
            return Usuario;
        }
    }
}
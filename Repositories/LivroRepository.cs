using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using sistema_bibliotecario_api.Data;
using sistema_bibliotecario_api.DTOs;
using sistema_bibliotecario_api.Models;

namespace sistema_bibliotecario_api.Repositories
{
    public class LivroRepository : ILivroRepository
    {

        private readonly AppDbContext _appDbcontext;
        public LivroRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
        public bool AddLivros(LivroCreateDto livro)
        {
            var Autor_id = _appDbcontext.Autores.Find(livro.Autor_id);
            if (Autor_id == null)
            {
                return false;
            }

            var Livro = new Livro
            {
                Titulo = livro.Titulo,
                Genero = livro.Genero,
                AnoPublicado = livro.AnoPublicado,
                Autor_id = livro.Autor_id
            };
            _appDbcontext.Livros.Add(Livro);
            _appDbcontext.SaveChanges();
            return true;
        }

        public Livro GetLivro(int id)
        {
            var Livro = _appDbcontext.Livros.Find(id);
            return Livro;
        }

        public List<Livro> GetLivros()
        {
            var Livros = _appDbcontext.Livros.ToList();
            return Livros;
        }

        public bool Update(int id, LivroCreateDto livroAtualizado)
        {
            var LivroExistente = _appDbcontext.Livros.Find(id);
            if (LivroExistente == null)
            {
                return false;
            }

            LivroExistente.Titulo = livroAtualizado.Titulo;
            LivroExistente.Genero = livroAtualizado.Genero;
            LivroExistente.AnoPublicado = livroAtualizado.AnoPublicado;
            _appDbcontext.SaveChanges();

            return true;


        }
        public bool Delete(int id)
        {
            var Livro = _appDbcontext.Livros.Find(id);

            if (Livro == null)
            {
                return false;
            }

            _appDbcontext.Livros.Remove(Livro);
            _appDbcontext.SaveChanges();

            return true;
        }

    }
}
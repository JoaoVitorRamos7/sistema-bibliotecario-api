using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using sistema_blibiotecario_api.Data;
using sistema_blibiotecario_api.DTOs;
using sistema_blibiotecario_api.Models;

namespace sistema_blibiotecario_api.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly AppDbContext _appDbcontext;
        public UsuarioRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
        public void AddUsuario(UsuarioCreateDto usuario)
        {
            var Usuario = new Usuario
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                DataNascimento = usuario.DataNascimento,

            };
            _appDbcontext.Usuarios.Add(Usuario);
            _appDbcontext.SaveChanges();

        }

        public List<Usuario> GetUsuarios()
        {
            var Usuario = _appDbcontext.Usuarios.ToList();
            return Usuario;
        }

        public bool Update(int id, UsuarioCreateDto usuario)
        {
            var UsuarioExistente = _appDbcontext.Usuarios.Find(id);
            if (UsuarioExistente == null)
            {
                return false;
            }
            UsuarioExistente.Nome = usuario.Nome;
            UsuarioExistente.Email = usuario.Email;
            UsuarioExistente.DataNascimento = usuario.DataNascimento;
            _appDbcontext.SaveChanges();
            return true;
            

        }

        public void Delete(int id)
        {
            var Usuario = _appDbcontext.Usuarios.Find(id);
            _appDbcontext.Usuarios.Remove(Usuario);
            _appDbcontext.SaveChanges();
        }

        public Usuario GetUsuario(int id)
        {
            var usuario = _appDbcontext.Usuarios.Find(id);
            return usuario;
        }
    }
}
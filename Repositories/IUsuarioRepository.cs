using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistema_bibliotecario_api.DTOs;
using sistema_bibliotecario_api.Models;

namespace sistema_bibliotecario_api.Repositories
{
    public interface IUsuarioRepository
    {
        void AddUsuario(UsuarioCreateDto usuario);
        List<Usuario> GetUsuarios();
        Usuario GetUsuario(int id);
        bool Update(int id, UsuarioCreateDto usuario);
        void Delete(int id);

    }
}
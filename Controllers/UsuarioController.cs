using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistema_bibliotecario_api.DTOs;
using sistema_bibliotecario_api.Repositories;

namespace sistema_bibliotecario_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpPost]
        public IActionResult AddUsuario(UsuarioCreateDto usuario)
        {
            var Usuario = usuario;
            if (Usuario == null)
            {
                return BadRequest();
            }
            _usuarioRepository.AddUsuario(usuario);
            return Ok("Usuario criado com sucesso!");
        }

        [HttpGet]
        public IActionResult GetUsuarios()
        {
            var Usuarios = _usuarioRepository.GetUsuarios();
            return Ok(Usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetUsuario(int id)
        {
            var Usuario = _usuarioRepository.GetUsuario(id);
            return Ok(Usuario);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateUsuario(int id, UsuarioCreateDto usuario)
        {
            var UsuarioNovo = usuario;
            _usuarioRepository.Update(id, UsuarioNovo);
            return Ok("Usuario Atualizado.");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _usuarioRepository.Delete(id);
            return Ok("Usuario deletado.");
        }
    }
}
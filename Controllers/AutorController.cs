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
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _autorRepository;
        public AutorController(IAutorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        [HttpPost]

        public IActionResult AddAutor(AutorCreateDto autor)
        {
            var Autor = autor;
            _autorRepository.AddAutor(Autor);
            return Ok("Autor adicionado com sucesso!");
        }

        [HttpGet]

        public IActionResult GetAutores()
        {
            var Autores = _autorRepository.GetAutores();
            return Ok(Autores);
        }

        [HttpGet("{id}")]
        public IActionResult GetAutor(int id)
        {
            var Usuario = _autorRepository.GetAutor(id);
            return Ok(Usuario);
        }

        [HttpPut("{id}")]

        public IActionResult Update(int id, AutorCreateDto autor)
        {
            var AutorNovo = autor;

            var Update = _autorRepository.Update(id, AutorNovo);
            if (!Update)
            {
                return BadRequest("Os dados fornecidos no corpo da requisição são inválidos.");
            }
            return Ok("Autor atualizado com sucesso!");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var Delete = _autorRepository.Delete(id);

            if (!Delete)
            {
                return NotFound("Autor não encontrado!");
            }

            return Ok("Autor deletado com sucesso!");

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sistema_bibliotecario_api.DTOs;
using sistema_bibliotecario_api.Models;
using sistema_bibliotecario_api.Repositories;

namespace sistema_bibliotecario_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;
        public LivrosController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpPost]
        public IActionResult AddLivro(LivroCreateDto livro)
        {
            var Livro = livro;
            if (Livro == null)
            {
                return BadRequest();
            }
            _livroRepository.AddLivros(Livro);
            return Ok("Livro adicionado com sucesso!");
        }


        [HttpGet]

        public IActionResult GetLivros()
        {
            var Livros = _livroRepository.GetLivros();
            return Ok(Livros);
        }

        [HttpGet("{id}")]

        public IActionResult GetLivro(int id)
        {
            var Livro = _livroRepository.GetLivro(id);
            return Ok(Livro);
        }

        [HttpPut("{id}")]

        public IActionResult Update(int id, LivroCreateDto livro)
        {
            var LivroExistente = livro;
            var Update = _livroRepository.Update(id, LivroExistente);
            if (!Update)
            {
                return BadRequest("Os dados fornecidos no corpo da requisição são inválidos.");
            }
            return Ok("Livro Atualizado com sucesso!");
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var Deletar = _livroRepository.Delete(id);
            if (!Deletar)
            {
                return NotFound("Livro não encontrado!");
            }
            return Ok("Livro deletado com sucesso!");
        }


    }
}
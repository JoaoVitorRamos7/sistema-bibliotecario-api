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


        /// <summary>
        /// Adiciona um novo livro ao sistema.
        /// </summary>

        [HttpPost]
        public IActionResult AddLivro(LivroCreateDto livro)
        {
            var Livro = livro;
            var Post = _livroRepository.AddLivros(Livro);
            if (!Post)
            {
                return BadRequest("Os dados fornecidos no corpo da requisição são inválidos.");
            }

            return Ok("Livro adicionado com sucesso!");
        }

        /// <summary>
        /// Retorna uma lista de todos os livros cadastrados no sistema.
        /// </summary>

        [HttpGet]

        public IActionResult GetLivros()
        {
            var Livros = _livroRepository.GetLivros();
            return Ok(Livros);
        }

        /// <summary>
        /// Retorna um livro específico com base no ID fornecido.
        /// </summary>

        [HttpGet("{id}")]

        public IActionResult GetLivro(int id)
        {
            var Livro = _livroRepository.GetLivro(id);
            if (Livro == null)
            {
                return NotFound("Livro não encontrado.");
            }
            ;
            return Ok(Livro);
        }

        /// <summary>
        /// Atualiza os dados de um livro existente com base no ID fornecido.
        /// </summary>

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

        /// <summary>
        /// Remove um livro do sistema com base no ID fornecido.
        /// </summary>

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
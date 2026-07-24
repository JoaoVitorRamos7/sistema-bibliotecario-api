using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sistema_bibliotecario_api.Models;

namespace sistema_bibliotecario_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
    }
}
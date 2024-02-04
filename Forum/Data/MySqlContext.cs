using Forum.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Forum.Data
{
    public class MySqlContext : DbContext
    {
        public MySqlContext() { }
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {

        }
        public DbSet<Topico> Topicos { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<Resposta> Respostas { get; set; } 
    }
}

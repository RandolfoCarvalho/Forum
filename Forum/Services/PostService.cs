using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Services
{
    public class PostService
    {
        private readonly MySqlContext _context;

        public PostService(MySqlContext context)
        {
            _context = context;
        }

        public List<Postagem> FindAll()
        {
            return _context
                .Postagens
                .Include(p => p.Respostas)
                .ToList();
        }
        public Postagem FindById(int id)
        {
            var result = _context.Postagens.SingleOrDefault(p => p.Id == id);
            return result;
        }

        public async Task InsertAsync(Postagem post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }
        public void Delete(int id)
        {
            var result = FindById(id);
            _context.Remove(result);
            _context.SaveChanges();
        }
    }
}

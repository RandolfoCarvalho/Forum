using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;

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
            return _context.Postagens.ToList();
        }

        public async Task InsertAsync(Postagem post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }
    }
}

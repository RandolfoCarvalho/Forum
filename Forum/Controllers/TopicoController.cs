using Forum.Data;
using Forum.Enums;
using Forum.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class TopicoController : Controller
    {
        private readonly MySqlContext _context;

        public TopicoController(MySqlContext context)
        {
            _context = context;
        }

        public IActionResult Random()
        {
            var postagensRandom = _context.Postagens
                .Where(p => p.TopicoId == (int)TopicoEnum.Random)
                .ToList();
            return Ok(postagensRandom);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

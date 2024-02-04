using Forum.Data;
using Forum.Enums;
using Forum.Models;
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

        private List<Postagem> ObterPostagensPorTopico(TopicoEnum topico)
        {
            return _context.Postagens
                .Where(p => p.TopicoId == (int)topico)
                .ToList();
        }

        public IActionResult Random()
        {
            var postagensRandom = ObterPostagensPorTopico(TopicoEnum.Random);
            return Ok(postagensRandom);
        }

        public IActionResult Jogos()
        {
            var postagensJogos = ObterPostagensPorTopico(TopicoEnum.Jogos);
            return Ok(postagensJogos);
        }
        public IActionResult JP()
        {
            var postagensJogos = ObterPostagensPorTopico(TopicoEnum.JP);
            return Ok(postagensJogos);
        }
        public IActionResult Med()
        {
            var postagensJogos = ObterPostagensPorTopico(TopicoEnum.Med);
            return Ok(postagensJogos);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

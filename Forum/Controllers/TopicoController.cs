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
        private readonly PostService _service;

        public TopicoController(PostService service)
        {
            _service = service;
        }

        private List<Postagem> ObterPostagensPorTopico(TopicoEnum topico)
        {
            var postagem = _service.FindAll();
            var posts = postagem.Where(p => p.TopicoId == (int)topico).ToList();
            return posts;
        }

        public IActionResult ObterPostagensPorTopicoAction(TopicoEnum topico)
        {
            var postagens = ObterPostagensPorTopico(topico);
            return Ok(postagens);
        }
        public IActionResult Random()
        {
            return ObterPostagensPorTopicoAction(TopicoEnum.Random);
        }

        public IActionResult Jogos()
        {
            return ObterPostagensPorTopicoAction(TopicoEnum.Jogos);
        }
        public IActionResult JP()
        {
            return ObterPostagensPorTopicoAction(TopicoEnum.JP);
        }
        public IActionResult Med()
        {
            return ObterPostagensPorTopicoAction(TopicoEnum.Med);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

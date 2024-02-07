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
        private List<Postagem> ObterPostagensOrdenadasPorRespostas(TopicoEnum topico)
        {
            var postagens = ObterPostagensPorTopico(topico);
            var postagensOrdenadas = postagens.OrderByDescending(p => p.Respostas.Count).ToList();
            return postagensOrdenadas;
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
            return View(ObterPostagensOrdenadasPorRespostas(TopicoEnum.Random));
           
        }

        public IActionResult Jogos()
        {
            return Ok(ObterPostagensOrdenadasPorRespostas(TopicoEnum.Jogos));
        }
        public IActionResult JP()
        {
            return Ok(ObterPostagensOrdenadasPorRespostas(TopicoEnum.JP));
        }
        public IActionResult Med()
        {
            return Ok(ObterPostagensOrdenadasPorRespostas(TopicoEnum.Med));
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

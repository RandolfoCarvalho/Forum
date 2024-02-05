using Forum.Data;
using Forum.Models;
using Forum.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Forum.Controllers
{
    public class RespostaController : Controller
    {
        private readonly MySqlContext _context;
        private readonly PostService _service;

        public RespostaController(MySqlContext context, PostService service)
        {
            _context = context;
            _service = service;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Resposta resposta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Modelo não é válido");
            }

            // Encontrar a postagem correspondente
            var postagem = _service.FindById(resposta.PostagemId);

            if (postagem == null)
            {
                return NotFound("Postagem não encontrada");
            }
            postagem.Respostas.Add(resposta);
            _context.Respostas.Add(resposta);
            await _context.SaveChangesAsync();
            return Ok(postagem);
        }

    }
}

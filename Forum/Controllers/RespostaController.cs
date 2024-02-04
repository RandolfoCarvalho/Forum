using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    public class RespostaController : Controller
    {
        private readonly MySqlContext _context;

        public RespostaController(MySqlContext context)
        {
            _context = context;
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Resposta resposta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Modelo não é válido");
            }

            _context.Respostas.Add(resposta);
            await _context.SaveChangesAsync();

            return Ok("Resposta criada com sucesso!");
        }
    }
}

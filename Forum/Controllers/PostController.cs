using Forum.Data;
using Forum.Models;
using Forum.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;

namespace Forum.Controllers
{
    public class PostController : Controller
    {
        private readonly PostService _service;

        public PostController(PostService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var result = _service.FindAll();
            if(result == null)
            {
                return NotFound("Id não encontrado");
            }
            return Ok(result);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Postagem post)
        {
            if(!ModelState.IsValid)
            {
                return StatusCode(400, "Modelo nao é válido");
            }
            await _service.InsertAsync(post);
            return RedirectToAction(nameof(Index));
        }
    }

}

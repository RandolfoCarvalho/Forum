using Microsoft.AspNetCore.Components.Web.Virtualization;
using System.Text.Json.Serialization;

namespace Forum.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataPublicacao { get; set; }

        public string TextArea { get; set; }
        public int TopicoId { get; set; }
        public virtual List<Resposta> Respostas { get; set; } = new List<Resposta>
    {
        new Resposta
        {
            TextArea = "Ola mundo",
            PostagemId = 11
        }
    };
    }
}
 
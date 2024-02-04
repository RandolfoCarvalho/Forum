namespace Forum.Models
{
    public class Resposta
    {
        public int Id { get; set; }

        // Relacionamento com a postagem
        public int PostagemId { get; set; }
        public Postagem Postagem { get; set; }
    }
}

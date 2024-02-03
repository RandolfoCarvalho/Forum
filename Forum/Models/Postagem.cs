namespace Forum.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Conteudo { get; set; }
        public DateTime DataPublicacao { get; set; }

        public int TopicoId { get; set; }
        public Topico Topico { get; set; }
    }
}

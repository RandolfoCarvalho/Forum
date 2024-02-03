namespace Forum.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataPublicacao { get; set; }
        public int TopicoId { get; set; }
    }
}
 
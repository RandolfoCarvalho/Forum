namespace Forum.Models
{
    public class Topico
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<Postagem> Postagens { get; set; }
    }
}

namespace BlueExpressAPI.Models
{
    public class Mensagem
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Remetente { get; set; }
        public string Destinatario { get; set; }
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; }
        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

    }
}
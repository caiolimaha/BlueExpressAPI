namespace BlueExpressAPI.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Cor { get; set; }
        public virtual List<Mensagem> Mensagens { get; set; }
    }
}
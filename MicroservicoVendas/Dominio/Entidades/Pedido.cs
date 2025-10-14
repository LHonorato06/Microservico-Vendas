namespace MicroservicoVendas.Dominio.Entidades;

public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public string Produto { get; set; } = string.Empty;
    public int Quantidade { get; set; }
    public DateTime DataCriacao { get; set; } = DateTime.Now;
}

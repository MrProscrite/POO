

namespace POO
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int ValorUnitario { get; set; }
        public Produto Produto { get; set; }
    }
}

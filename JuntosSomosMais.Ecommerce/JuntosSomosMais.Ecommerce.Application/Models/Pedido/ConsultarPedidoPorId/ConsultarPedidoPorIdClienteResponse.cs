namespace JuntosSomosMais.Ecommerce.Application.Models.Pedido.ConsultarPedidoPorId
{
    public class ConsultarPedidoPorIdClienteResponse
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }

        //o private assegura que essas informações são sejam alteradas a partir de outras classes
    }
}

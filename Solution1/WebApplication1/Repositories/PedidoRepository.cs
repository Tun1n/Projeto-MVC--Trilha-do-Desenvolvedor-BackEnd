using WebApplication1.Context;
using WebApplication1.Models;
using WebApplication1.Repositories.Interfaces;

namespace WebApplication1.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbcontext;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoRepository(AppDbContext appDbcontext, CarrinhoCompra carrinhoCompra)
        {
            _appDbcontext = appDbcontext;
            _carrinhoCompra = carrinhoCompra;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbcontext.Pedidos.Add(pedido);
            _appDbcontext.SaveChanges();    

            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItems;

            foreach(var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetalhe = new PedidoDetalhe()
                {
                    BebidaId = carrinhoItem.Bebida.BebidaId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Bebida.Preco,
                    Quantidade = carrinhoItem.Quantidade
                };
                _appDbcontext.PedidoDetalhes.Add(pedidoDetalhe);
            }
            _appDbcontext.SaveChanges();
        }
    }

}

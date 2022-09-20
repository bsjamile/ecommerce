using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Infra.Repositories
{
    public class PedidoRepository : IPedidoRepository //herda o que foi atribuido na interface do pedido
    {
        private readonly ApplicationContext _context; //representa o banco de dados configurado na ApplicationContext
        public PedidoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Cadastrar(Pedido pedido)
        {
            _context.Pedidos.Add(pedido); //adicionar as informacoes do pedido
            await _context.SaveChangesAsync(); //salvar essas informacoes no banco de dados
        }

        public async Task<Pedido> ConsultarPorId(int id)
        {
            var result = _context
                 .Pedidos //acessar as informacoes do banco de dados da tabela Pedidos que foi definido no ApplicationContext
                 .Include(i => i.PedidoProdutos)
                     .ThenInclude(i => i.Produto) //incluir as informacoes dos produtos correspondentes ao pedido
                 .Include(i => i.Cliente) //incluir as informacoes do cliente correspondentes ao pedido
                 .AsQueryable(); //sequenciar as informacoes

            if (id != 0) //se o id nao for 0, procurar as informacoes sobre o pedido correspondente a esse id no banco de dados 
            {
                result = result.Where(w => w.Id == id);
                return await result
                 .AsNoTracking() //retorna uma consulta e as informacoes nao serao armazenadas 
                 .FirstOrDefaultAsync(); //busca o primeiro resultado correspondente ao id
            }
            else
                return await Task.FromResult(_context.Find<Pedido>(id));  
            //se o id nao tiver resultado, tente encontrar e la no controller vai retornar uma mensagem pedindo para digitar um id valido
        }
    }
}

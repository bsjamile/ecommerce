using JuntosSomosMais.Ecommerce.Core.Entities;
using JuntosSomosMais.Ecommerce.Core.Filters;
using JuntosSomosMais.Ecommerce.Core.Repositories;
using JuntosSomosMais.Ecommerce.Infra.DataBase;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Infra.Repositories
{
    public class ProdutoRepository : IProdutoRepository //herda o que foi atribuido na interface do produto
    {
        private readonly ApplicationContext _context; //representa o banco de dados configurado na ApplicationContext
        public ProdutoRepository(ApplicationContext context)
        {
            _context = context;
        }
        public async Task Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto); //adicionar as informacoes do produto
            await _context.SaveChangesAsync(); //salvar essas informacoes no banco de dados
        }

        public async Task<Produto> ConsultarPorId(GetFilterProduto filter)
        {
            var result = _context
                .Produtos //acessar as informacoes do banco de dados da tabela Produtos que foi definido no ApplicationContext
                .AsQueryable();

            if (filter.Id != 0) //se o id for diferente de 0, retorne as informacoes do id correspondente
            {
                result = result.Where(w => w.Id == filter.Id);
            }
            else if (!string.IsNullOrEmpty(filter.Produto)) //se o nome do produto nao for vazio, retorne as informacoes do produto
                                                            //com o nome correspondente
            {
                result = result.Where(w => w.Nome.Contains(filter.Produto));
            }
            else //se o id for 0 e o produto for vazio, atribua nulo ao filtro que no Controller
                 //vai retornar uma mensagem pedindo um id ou um nome de produto valido
            {
                filter = null;
                return await Task.FromResult(_context.Find<Produto>(filter));
            }

            return await result
                .AsNoTracking() //retorna uma consulta e as informacoes nao serao armazenadas 
                .FirstOrDefaultAsync(); //busca o primeiro resultado correspondente àquele id
        }
    }
}
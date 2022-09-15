using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuntosSomosMais.Ecommerce.Core.Filters
{
    public class GetFilterProduto : GetFilterPorId
    { 
        public string Produto { get; set; }
    }
}

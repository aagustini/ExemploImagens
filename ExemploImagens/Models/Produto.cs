using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploImagens.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }
        public virtual ICollection<Imagem> Imagens { get; set; }
    }
}

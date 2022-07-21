using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.src
{
    public class Funcionario
    {
        public string Nome { get; }
        protected decimal _pagamentobase;


        public Funcionario(string nome, decimal pagamentobase)
        {
            Nome = nome;
            _pagamentobase = pagamentobase;
        }

        public virtual decimal CalculoDePagamento()
        {
            return _pagamentobase;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo.src
{ 
        public class VendasFuncionario : Funcionario
        {
            private decimal _bonusvendas;

            public VendasFuncionario(string nome, decimal pagamentobase, decimal bonusvendas) : base(nome, pagamentobase)
            {
                _bonusvendas = bonusvendas;
            }

        public override decimal CalculoDePagamento()
            {
                return _pagamentobase + _bonusvendas;
            }
        }

}

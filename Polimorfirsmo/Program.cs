using System;
using Polimorfismo.src;
namespace Polimorfirsmo
{
    class Program
    {
    
    

        static void Main()
        {
      
            var funcionario1 = new VendasFuncionario("Jean", 1000, 500);
            var funcionario2 = new Funcionario("Isa", 1200);

            Console.WriteLine($"Funcionário 1 {funcionario1.Nome} recebeu: {funcionario1.CalculoDePagamento()}");
            Console.WriteLine($"Funcionário 2 {funcionario2.Nome} recebeu: {funcionario2.CalculoDePagamento()}");
        }
    }
}

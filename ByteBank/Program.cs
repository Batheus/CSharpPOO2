using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.789-10";
            carlos.Salario = 2000;
            gerenciador.Registrar(carlos);

            /* Por termos herdado as características do Funcionário na classe Diretor, 
             * podemos criar um Diretor até mesmo dessa forma:
             * Funcionario pedro = new Diretor();
            */

            Diretor rodolfo = new Diretor();

            rodolfo.Nome = "Rodolfo";
            rodolfo.CPF = "123.654.789-10";
            rodolfo.Salario = 8000;
            gerenciador.Registrar(rodolfo);


            Console.WriteLine("Nome do funcionário: " + carlos.Nome);
            Console.WriteLine("CPF do funcionário: " + carlos.CPF);
            Console.WriteLine("Salário do funcionário: " + carlos.Salario);

            Console.WriteLine("A bonificação do funcionário " + carlos.Nome + " será de: R$" + carlos.GetBonificacao());
            Console.WriteLine("O salário total do funcionário " + carlos.Nome + " será de: R$" + (carlos.GetBonificacao() + carlos.Salario));


            Console.WriteLine( );

            Console.WriteLine("Nome do funcionário: " + rodolfo.Nome);
            Console.WriteLine("CPF do funcionário: " + rodolfo.CPF);
            Console.WriteLine("Salário do funcionário: " + rodolfo.Salario);

            Console.WriteLine("A bonificação do funcionário " + rodolfo.Nome + " será de: R$" + rodolfo.GetBonificacao());
            Console.WriteLine("O salário total do funcionário " + rodolfo.Nome + " será de: R$" + (rodolfo.GetBonificacao() + rodolfo.Salario));

            Console.WriteLine();
            Console.WriteLine("Total de bonificações: R$" + gerenciador.GetTotalBonificacao());


            Console.ReadLine();
        }
    }
}
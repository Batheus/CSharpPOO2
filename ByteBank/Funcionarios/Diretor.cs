using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    // Os : foi utilizado para que o Diretor herde as características e comportamento do Funcionario
    // Por isso não precisamos repetir as declarações de Nome, CPF e Salário
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf) //Foi estipulado o salário de 5000 para todos os diretos como regra de negócio
        {
            Console.WriteLine("Criando DIRETOR");
        }

        // Foi utilizado override para que ele sobrescreva o GetBonificacao() do Funcionario
        public override double GetBonificacao()
        {
            // base serve pra gente puxar o GetBonificacao da classe base (Funcionario)
            //return Salario + base.GetBonificacao();
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}

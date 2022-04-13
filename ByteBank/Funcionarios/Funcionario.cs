using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    /* Tornando a classe Funcionário abstrata, deixamos de poder criar objetos com a classe
     * evitando assim possíveis erros. 
     * Ainda podemos nos befeniciar das caracterísitcas da classe, como a bonificação ou aumentar salário*/
    public abstract class Funcionario
    {
        /*
         * Modificadores de acesso:
         * Set: Vem por padrão no prop, público
         * Private: Privado, só a própria classe consegue manipular
         * Protected: Semi-privado, subclasses conseguem manipular*/
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");
            TotalDeFuncionarios++;
            Salario = salario;
            CPF = cpf;
        }
        
        /* Tornamos tanto a classe AumentarSalario e GetBonificacao abstratas
         * para "obrigar" o desenvolvedor a sobrescrever as classes
         * com características específicas */
        public abstract void AumentarSalario();
        public abstract double GetBonificacao();
    }
}

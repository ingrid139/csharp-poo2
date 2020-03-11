using System;

namespace _03_ByteBankRh.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        
        //public double Salario { get; private set; }
        //Para tipos derivados poderem utilizar, de fora da classe continua sem acesso
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        //public Funcionario(string cpf)
        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            Salario = salario;
        }
        //virtual - tem uma implementação mas permite que outra classe sobreescreva o metodo
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public virtual void AumentarSalario()
        {
            //Salario = Salario + (Salario * 0.1);
            //Salario = Salario * 1.1;
            Salario *= 1.1;
        }
    }
}

using System;

namespace _05_ByteBankRh.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            TotalDeFuncionarios++;
            Console.WriteLine("Criando Funcionario");

            CPF = cpf;
            Salario = salario;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
    }
}

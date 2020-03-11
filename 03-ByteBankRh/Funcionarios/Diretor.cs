using System;

namespace _03_ByteBankRh.Funcionarios
{
    public class Diretor : Funcionario
    {
        //passar argumentos para classe base
        //public Diretor() que vai chamar base()
        //podemos passar um argumento literal para classe base
        public Diretor(string cpf) : base (5000, cpf)
        {
            Console.WriteLine("Criando Diretor");
        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
